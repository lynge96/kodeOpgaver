import matplotlib.pyplot as plt
import numpy as np

def linear_regression(X, y, theta0=0, theta1=0, epochs=10000,
learning_rate=0.0001):
    N = float(len(y))
    for i in range(epochs):
        y_hypothesis = (theta1 * X) + theta0
        cost = sum([data**2 for data in (y-y_hypothesis)]) / N
        theta1_gradient = -(2/N) * sum(X * (y - y_hypothesis))
        theta0_gradient = -(2/N) * sum(y - y_hypothesis)
        theta0 = theta0 - (learning_rate * theta0_gradient)
        theta1 = theta1 - (learning_rate * theta1_gradient)

    return theta0, theta1, cost

X = 2 * np.random.rand(100, 1)
y = 4 + 3 * X + np.random.randn(100, 1)

theta0, theta1, cost = linear_regression(X, y, 0, 0, 1000, 0.01)

plt.plot(X,y, "b.")
plt.axis([0,2,0,15])

# lets plot that line:
X_new = np.array([[0],[2]])
X_new_b = np.c_[np.ones((2,1)), X_new]
y_predict = X_new_b.dot([theta0, theta1])

plt.plot(X_new, y_predict, "g-")
plt.show()