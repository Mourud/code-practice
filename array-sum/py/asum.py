def asum(arr):
    sum = 0
    for int in arr:
        sum += int
    return sum

arr = [1,2,3,4]
print('Input array: ' + str(arr))
print ('Sum: ' + str(asum([1,2,3,4])))