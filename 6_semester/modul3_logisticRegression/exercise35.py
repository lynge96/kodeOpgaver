# -*- coding: utf-8 -*-
"""
Created on Sun Apr 15 17:51:09 2018

@author: Sila
"""

# https://machinelearningmastery.com/machine-learning-in-python-step-by-step/

from sklearn.linear_model import LogisticRegression
import pandas
import matplotlib.pyplot as plt
import numpy as np
from pandas.plotting import scatter_matrix

#from sklearn import datasets

# Load dataset
url = "https://archive.ics.uci.edu/ml/machine-learning-databases/iris/iris.data"
names = ['sepal-length', 'sepal-width', 'petal-length', 'petal-width', 'class']
dataset = pandas.read_csv(url, names=names)

print(list(dataset.keys()))

# shape
print(dataset.shape)

# head
print(dataset.head(20))

# descriptions
print(dataset.describe())

# histograms
dataset.hist()
plt.show()


# scatter plot matrix
scatter_matrix(dataset)
plt.show()


array = dataset.values
#X = array[:,0:4]
X = array[:,3]  # petal width
Y = array[:,4]  # classification

# Make y into numbers
a_enc = pandas.factorize(Y)
yvalues = a_enc[0]

y = []

for i in yvalues: 
  if i == 2:
     y = np.append(y,[1])
  else:
     y = np.append(y,[0])

# l2 is default, 
# Intuitively, the model will be adjusted to minimize single outlier case, 
# at the expense of many other common examples     
log_reg = LogisticRegression(penalty="l2")
# Shape, gives a new shape to an array without changing its data. In order to use algorithm
log_reg.fit(X.reshape(-1, 1),y)

plt.plot(X,y,"b.")

X_new = np.linspace(0,3,1000).reshape(-1,1)
y_proba = log_reg.predict_proba(X_new)

plt.plot(X_new,y_proba[:,1],"g-",label="Iris-Virginica")
plt.plot(X_new,y_proba[:,0],"b--",label="Not Iris-Virginca")
plt.xlabel("Petal width", fontsize=14)
plt.ylabel("Probability", fontsize=14)
plt.legend(loc="upper left", fontsize=14)
plt.show()

