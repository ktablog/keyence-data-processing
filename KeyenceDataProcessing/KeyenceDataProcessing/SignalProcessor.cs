using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace KeyenceDataProcessing
{
    public class SignalProcessor
    {
        #region Field
        private const int _nOfDots = 800;
        private const int _nOfZHistoColumns = 7;
        private const int _searchSignalCount = 3;
        private const double _signalDiffMax = 0.5;
        private int[] _validSignalRange = null;
        private double[] _validSignal = null;
        private double[] _searchSignal = null;
        private List<double[]> _searchSignalsList = new List<double[]>();
        private int _searchSignalOffset = 0;
        private bool _searchError = true;
        private double _yValue;
        private double _zValue;
        #endregion

        #region Property

        public int NofDots
        {
            get { return _nOfDots; }
        }

        public int SearchSignalsCount
        {
            get { return _searchSignalsList.Count; }
        }

        public List<double[]> SearchSignalsList
        {
            get { return _searchSignalsList; }
        }

        #endregion

        #region Delegate
        delegate bool ChooseValue(double v1, double v2);
        #endregion

        #region Method

        public SignalProcessor()
        {
            BuildSearchSignal();
        }


        private void BuildSearchSignal()
        {
            int n = (int)(_nOfDots * 0.2);
            _searchSignalsList.Add(_searchSignal = BuildSearchSignalVariant1(n));
            _searchSignalsList.Add(BuildSearchSignalVariant2(n));
            _searchSignalsList.Add(BuildSearchSignalVariant3(n));
        }


        private double[] BuildSearchSignalVariant1(int n)
        {
            const double xPart = 0.5;
            const double y0 = 0.0;
            const double y1 = 10.0;

            double[] data = new double[n];
            double x;
            double y;
            double x0 = n * (1 - xPart) / 2;
            double x1 = n / 2;
            double x2 = n - 1 - x0;
            double yK = (y1 - y0) / (x2 - x1);

            for (int i = 0; i < n; i++)
            {
                x = i;
                if (x < x0 || x > x2)
                {
                    y = y0;
                }
                else if (x < x1)
                {
                    y = y0 + (x - x0) * yK;
                }
                else
                {
                    y = y0 + (x2 - x) * yK;
                }
                data[i] = -y;
            }

            return data;
        }


        private double[] BuildSearchSignalVariant2(int n)
        {
            const double xPart = 0.5;
            const double y0 = 0.0;
            const double y1 = 10.0;

            double[] data = new double[n];
            double x;
            double y;
            double x0 = n * (1 - xPart) / 2;
            double x2 = n - 1 - x0;

            for (int i = 0; i < n; i++)
            {
                x = i;
                if (x < x0 || x > x2)
                {
                    y = y0;
                }
                else
                {
                    y = y1;
                }
                data[i] = -y;
            }

            return data;
        }


        private double[] BuildSearchSignalVariant3(int n)
        {
            const double y0 = 0.0;
            const double y1 = 10.0;
            double[] xParts = 
            {
                0.3, 0.4, 0.5, 0.6, 0.7
            };
            double[] yParts =
            {
                0.0, 1.0, 0.2, 1.0, 0.0
            };
            Debug.Assert(xParts.Length == yParts.Length);

            double[] data = new double[n];

            for (int i = 0; i < n; i++)
            {
                data[i] = y0;
            }

            for (int j = 0; j < xParts.Length - 1; j++)
            {
                int xIndex0 = (int)(xParts[j] * (n - 1));
                int xIndex1 = (int)(xParts[j + 1] * (n - 1));

                if (xIndex0 < 0) xIndex0 = 0;
                if (xIndex1 > n) xIndex1 = n;

                if (xIndex0 >= xIndex1) break;

                double k =
                    (yParts[j + 1] - yParts[j]) /
                    (xParts[j + 1] - xParts[j]);

                for (int i = xIndex0; i < xIndex1; i++)
                {
                    double x = (double)i / (n - 1);
                    data[i] = ((x - xParts[j]) * k + yParts[j]) *
                        (y0 - y1) + y0;
                }
            }

            return data;
        }


        double CalcConv(int offset, double[] longArr, double[] shortArr)
        {
            int longArrLen = longArr.Length;
            int shortArrLen = shortArr.Length;
            double sum = 0.0;

            for (int i = 0; i < shortArrLen; i++)
            {
                int longArrIndex = i + offset;
                if (longArrIndex < 0)
                    continue;
                if (longArrIndex >= longArrLen)
                    break;
                sum += shortArr[i] * longArr[longArrIndex];
            }

            return sum;
        }


        private KeyValuePair<int, double> FindValue(double[] arr, ChooseValue func)
        {
            int index = -1;
            double val = 0.0;
            int n = arr.Length;

            if (n > 0)
            {
                val = arr[index = 0];

                for (int i = 1; i < n; i++)
                {
                    if (func(arr[i], val))
                    {
                        val = arr[index = i];
                    }
                }
            }

            return new KeyValuePair<int, double>(index, val);
        }


        private KeyValuePair<int, double> FindMax(double[] arr)
        {
            ChooseValue cv = delegate(double v1, double v2)
            {
                return v1 > v2;
            };

            return FindValue(arr, cv);
        }


        private KeyValuePair<int, double> FindMin(double[] arr)
        {
            ChooseValue cv = delegate(double v1, double v2)
            {
                return v1 < v2;
            };

            return FindValue(arr, cv);
        }


        private List<double>[] BuildHisto(double[] arr, int columnsCount)
        {
            List<double>[] histo = new List<double>[columnsCount];

            for (int i = 0; i < columnsCount; i++)
            {
                histo[i] = new List<double>();
            }

            double[] ranges = new double[columnsCount - 1];

            double min = FindMin(arr).Value;
            double max = FindMax(arr).Value;
            if (min == max)
                max += 1.0;

            double delta = (max - min) / columnsCount;

            for (int i = 0; i < columnsCount - 1; i++)
            {
                ranges[i] = min + (i + 1) * delta;
            }

            foreach (double val in arr)
            {
                int index = columnsCount - 1;
                for (int i = 0; i < index; i++)
                {
                    if (val < ranges[i])
                    {
                        index = i;
                        break;
                    }
                }

                histo[index].Add(val);
            }

            return histo;
        }


        public SignalProcessorDataOut Calc(SignalProcessorDataIn dataIn)
        {
            _validSignalRange = FindValidSignal(dataIn._entrySignal, -20);
            _validSignal = ExtractValidSignal(dataIn._entrySignal, _validSignalRange);
            if (_validSignal == null)
            {
                _searchError = true;
            }
            else
            {
                CalcY(dataIn);
                CalcZ();
            }

            SignalProcessorDataOut dataOut = new SignalProcessorDataOut();
 
            dataOut._searchError = _searchError;
            if (!_searchError)
            {
                double[] copiedSearchSignal = new double[_searchSignal.Length];
                Array.Copy(_searchSignal, copiedSearchSignal, _searchSignal.Length);
                dataOut._searchSignal = copiedSearchSignal;
            }
            dataOut._searchSignalOffset = _searchSignalOffset;
            dataOut._yValue = _yValue;
            dataOut._zValue = _zValue;
            return dataOut;
        }


        private void CalcY(SignalProcessorDataIn dataIn)
        {
            int offset = 0;
            bool err = false;

            double[] firstSearchSignal = _searchSignalsList[0];
            double[] removedCurvatureSignal = RemoveSignalCurvature(_validSignal);
            int convolutionLen = removedCurvatureSignal.Length - firstSearchSignal.Length + 1;
            double[] convolution = new double[convolutionLen];

            double maxConv = 0.0;
            int maxConvIndex = -1;
            for (int i = 0; i < convolutionLen; i++)
            {
                double conv = CalcConv(i, removedCurvatureSignal, firstSearchSignal);
                if (maxConvIndex < 0)
                {
                    maxConv = conv;
                    maxConvIndex = 0;
                }
                else
                {
                    if (conv > maxConv)
                    {
                        maxConv = conv;
                        maxConvIndex = i;
                    }
                }
            }

            offset = maxConvIndex + _validSignalRange[0] + 1;

            double[] entrySignalSlice = GetArraySlice(dataIn._entrySignal, offset, _searchSignal.Length);
            double[] normalizedEntrySignalSlice = NormalizeSignal(entrySignalSlice);
            List<double[]> normalizedSearchSignalsList = new List<double[]>();
            for (int i = 0; i < SearchSignalsCount; i++)
            {
                normalizedSearchSignalsList.Add(NormalizeSignal(_searchSignalsList[i]));
            }

            List<double> diffList = new List<double>();
            for (int i = 0; i < SearchSignalsCount; i++)
            {
                diffList.Add(CalcSignalDiff(normalizedEntrySignalSlice, normalizedSearchSignalsList[i]));
            }
            int indexOfMin = 0;
            for (int i = 1; i < SearchSignalsCount; i++)
            {
                double min = diffList[indexOfMin];
                if (min > diffList[i])
                {
                    indexOfMin = i;
                }
            }
            //indexOfMin = 2;
            double diff = diffList[indexOfMin];
            _searchSignal = _searchSignalsList[indexOfMin];

            Console.Out.WriteLine(indexOfMin + " " + diff);

            if (diff > _signalDiffMax)
                err = true;

            _yValue = offset + _searchSignalsList[0].Length / 2;
            _searchError = err;
            _searchSignalOffset = offset;
        }


        private void CalcZ()
        {
            List<double>[] histo = BuildHisto(_validSignal, _nOfZHistoColumns);

            int columnIndex = 0;
            int maxCount = histo[columnIndex].Count;
            for (int i = 1; i < histo.Length; i++)
            {
                int count = histo[i].Count;
                if (count > maxCount)
                {
                    maxCount = count;
                    columnIndex = i;
                }
            }

            int valuesCount = 0;
            double sum = 0.0;
            for (int i = columnIndex - 1; i <= columnIndex + 1; i++)
            {
                if (i < 0)
                    continue;
                if (i >= histo.Length)
                    break;

                List<double> column = histo[i];
                valuesCount += column.Count;

                foreach (double v in column)
                {
                    sum += v;
                }
            }

            double avr = valuesCount == 0 ? 0 : sum / valuesCount;

            _zValue = avr;
        }


        private int[] FindValidSignal(double[] inData, double minValue)
        {
            int loIndex = -1;
            for (int i = 0; i < inData.Length; i++)
            {
                if (inData[i] > minValue)
                {
                    break;
                }
                loIndex = i;
            }

            int hiIndex = inData.Length;
            for (int i = inData.Length - 1; i >= 0; i--)
            {
                if (inData[i] > minValue)
                {
                    break;
                }
                hiIndex = i;
            }

            return new int[] { loIndex, hiIndex };
        }


        private double[] ExtractValidSignal(double[] inData, int[] range)
        {
            int loIndex = range[0];
            int hiIndex = range[1];

            if (loIndex >= hiIndex)
            {
                return null;
            }

            int validDataSize = hiIndex - loIndex - 1;
            double[] validData = new double[validDataSize];

            for (int i = 0; i < validDataSize; i++)
            {
                validData[i] = inData[i + loIndex + 1];
            }

            return validData;
        }


        private double CalcDeterminant3(double[,] a)
        {
            return a[0, 0] * a[1, 1] * a[2, 2] +
                    a[0, 1] * a[1, 2] * a[2, 0] +
                    a[0, 2] * a[1, 0] * a[2, 1] -
                    a[0, 0] * a[1, 2] * a[2, 1] -
                    a[0, 1] * a[1, 0] * a[2, 2] -
                    a[0, 2] * a[1, 1] * a[2, 0];
        }


        private double[] SolveLinear3(double[,] arrIn)
        {
            int n = 3;
            double[] desI = { 0, 0, 0 };
            double[,] matrix = new double[,]
            {
                {0, 0, 0}, 
                {0, 0, 0}, 
                {0, 0, 0}
            };

            for (int i = 0; i < n; i++)
            {
                matrix[i, 0] = arrIn[i, 0];
                matrix[i, 1] = arrIn[i, 1];
                matrix[i, 2] = arrIn[i, 2];
            }
            double des = CalcDeterminant3(matrix);
            if (des == 0)
            {
                return null;
            }

            for (int i = 0; i < n; i++)
            {
                matrix[i, 0] = arrIn[i, 3];
                matrix[i, 1] = arrIn[i, 1];
                matrix[i, 2] = arrIn[i, 2];
            }
            desI[0] = CalcDeterminant3(matrix);


            for (int i = 0; i < n; i++)
            {
                matrix[i, 0] = arrIn[i, 0];
                matrix[i, 1] = arrIn[i, 3];
                matrix[i, 2] = arrIn[i, 2];
            }
            desI[1] = CalcDeterminant3(matrix);


            for (int i = 0; i < n; i++)
            {
                matrix[i, 0] = arrIn[i, 0];
                matrix[i, 1] = arrIn[i, 1];
                matrix[i, 2] = arrIn[i, 3];
            }
            desI[2] = CalcDeterminant3(matrix);


            var aout = new double[3];
            for (int i = 0; i < 3; i++)
            {
                aout[i] = desI[i] / des;
            }
            return aout;
        }


        private double[] CalcFactors3(double[,] arrIn)
        {
            int n = arrIn.Length / 2;

            double x;
            double y;
            double x2;
            double mx = 0.0;
            double my = 0.0;
            double mxy = 0.0;
            double mx2y = 0.0;
            double mx2 = 0.0;
            double mx3 = 0.0;
            double mx4 = 0.0;

            for (int i = 0; i < n; i++)
            {
                x = arrIn[i, 0];
                y = arrIn[i, 1];
                mx += x;
                my += y;
                mxy += x * y;
                x2 = x * x;
                mx2y += x2 * y;
                mx2 += x2;
                mx3 += x2 * x;
                mx4 += x2 * x2;
            }

            if (n > 0)
            {
                return SolveLinear3(new double[,] {
                    {mx4, mx3, mx2, mx2y},
                    {mx3, mx2, mx,  mxy},
                    {mx2, mx,  n,   my}
                });
            }

            return null;
        }


        private double CalcPolinom3(double[] factors, double arg)
        {
            return factors[0] * arg * arg +
                    factors[1] * arg +
                    factors[2];
        }


        private double[,] BuildArrayXY(double[] arrIn)
        {
            int n = arrIn.Length;
            double[,] arrOut = new double[n, 2];
            for (int i = 0; i < n; i++)
            {
                arrOut[i, 0] = i;
                arrOut[i, 1] = arrIn[i];
            }
            return arrOut;
        }


        private double[] RemoveSignalCurvature(double[] inArr)
        {
            int signalSize = inArr.Length;
            double[] outArr = new double[signalSize];

            double[,] xyArr = BuildArrayXY(inArr);
            double[] factors = CalcFactors3(xyArr);

            for (int i = 0; i < inArr.Length; i++)
            {
                //outArr[i] = inArr[i];
                outArr[i] = inArr[i] - CalcPolinom3(factors, i);
            }

            return outArr;
        }


        private double[] NormalizeSignal(double[] inArr)
        {
            int arrSize = inArr.Length;
            double[] outArr = new double[arrSize];

            double min = FindMin(inArr).Value;
            double max = FindMax(inArr).Value;

            double a;
            double b = (max + min) / 2;
            if (min == max)
            {
                a = 0;
            }
            else
            {
                a = 2 / (max - min);
            }

            for (int i = 0; i < arrSize; i++)
            {
                outArr[i] = (inArr[i] - b) * a;
            }

            return outArr;
        }


        private double CalcSignalDiff(double[] arr1, double[] arr2)
        {
            int n = arr1.Length;
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += Math.Abs(arr1[i] - arr2[i]);
            }

            return sum / n;
        }


        private double[] GetArraySlice(double[] arr, int offset, int size)
        {
            double[] slice = new double[size];

            for (int i = 0; i < size; i++)
            {
                slice[i] = arr[offset + i];
            }

            return slice;
        }

        #endregion
    }


    public class SignalProcessorDataIn
    {
        public double[] _entrySignal = null;
    }


    public class SignalProcessorDataOut
    {
        public double[] _searchSignal = null;
        public bool _searchError = true;
        public double _yValue = 0.0;
        public double _zValue = 0.0;
        public int _searchSignalOffset = 0;
    }
}
