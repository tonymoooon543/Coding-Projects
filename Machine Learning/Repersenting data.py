# This file includes Mean, Median, Mode, Stantered Devation, and Percentile
import numpy
from scipy import stats

array = [99,86,87,88,111,86,103,87,94,78,77,85,86]

mean = numpy.mean(array)
meadian = numpy.median(array)
mode = stats.mode(array)
std = numpy.std(array)
variance = numpy.var(array)
percentile = numpy.percentile(array, 80)

print(mean, mode, meadian, std, variance, percentile)