#This is a short example of using a MLpClassifier to predict data.

#First we will import the data and just visualize them to get an idea of how it looks.

from sklearn.datasets import load_iris
import matplotlib.pyplot as plt
from matplotlib.colors import ListedColormap

iris = load_iris()
#print(iris)

# petal length and width, so 2D information, only use the first two data rows
X = iris.data[:,(2,3)] # the :, indicates we want all row values for the two columns (column 2 and 3)
y = iris.target  # these are the correct classifications
# check how many samples we have
#print(X)
print("Number of samples: " +str(len(y)))
#visulize the dataset
plt.figure()
#define colors - red, green, blue
colormap = ListedColormap(['#FF0000', '#00FF00', '#0000FF'])
# pplot labxel
plt.xlabel(iris.feature_names[2])
plt.ylabel(iris.feature_names[3])
# Plot the training points
plt.scatter(X[:, 0], X[:, 1], c=y, cmap=colormap,edgecolor='black', s=20)

plt.show()

# Split in train and test set
from sklearn.model_selection import train_test_split
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size = 0.2)

# Feature scaling
from sklearn.preprocessing import StandardScaler
scaler = StandardScaler()
scaler.fit(X_train)

X_train = scaler.transform(X_train)
X_test = scaler.transform(X_test)

from sklearn.neural_network import MLPClassifier
mlp = MLPClassifier(hidden_layer_sizes=(1000, 3), max_iter=1000)
mlp.fit(X_train, y_train)

#predictions
predictions = mlp.predict(X_test)

print(predictions)

import numpy as np

h = .02  # step size in the mesh

# create a mesh to plot in
x_min, x_max = X_test[:, 0].min() - 1, X_test[:, 0].max() + 1
y_min, y_max = X_test[:, 1].min() - 1, X_test[:, 1].max() + 1
xx, yy = np.meshgrid(np.arange(x_min, x_max, h),
                     np.arange(y_min, y_max, h))

plt.subplot(1, 1, 1)
plt.subplots_adjust(wspace=0.4, hspace=0.4)

Z = mlp.predict(np.c_[xx.ravel(), yy.ravel()])

# Put the result into a color plot
Z = Z.reshape(xx.shape)
plt.contourf(xx, yy, Z, cmap=plt.cm.coolwarm, alpha=0.8)

# Plot also the training points
plt.scatter(X_test[:, 0], X_test[:, 1], c=y_test)
plt.xlabel('Petal length')
plt.ylabel('Petal width')
plt.title("MLP")

plt.show()
