import matplotlib.pyplot as plt
import numpy as np

def cost(a, b, X, y):
    ### Evaluate half MSE (Mean square error)
    m = len(y)
    error = a + b * X - y
    J = np.sum(error ** 2) / (2 * m)
    return J


X = 2 * np.random.rand(100, 1)
y = 4 + 3 * X + np.random.randn(100, 1)

ainterval = np.arange(1, 10, 0.01)
binterval = np.arange(0.5, 5, 0.01)

low = cost(0, 0, X, y)
bestatheta = 0
bestbtheta = 0
for atheta in ainterval:
    for btheta in binterval:
        # print("xy: %f:%f:%f" % (atheta,btheta,cost(atheta,btheta, X, y)))
        if (cost(atheta, btheta, X, y) < low):
            low = cost(atheta, btheta, X, y)
            bestatheta = atheta
            bestbtheta = btheta

print("a and b: %f:%f" % (bestatheta, bestbtheta))

plt.plot(X,y, "b.")
plt.axis([0,2,0,15])
plt.plot()
plt.show()