# -*- coding: utf-8 -*-
"""
Created on Wed Apr 18 19:34:09 2018

@author: Sila
"""

import matplotlib.pyplot as plt
import numpy as np
from sklearn import linear_model

# Array of points with a classification
X = np.array(np.matrix('2,300;4,600;7,300;5,500;5,400;6,400;3,400;4,500;1,200;3,400;7,700;3,550;2.5,650'))
y = np.array(np.matrix('0;1;1;1;0;1;0;0;0;0;1;1;0'))[:,0]

pos=np.where(y==1)
neg=np.where(y==0)

plt.plot(X[pos[0],0], X[pos[0],1], 'ro')
plt.plot(X[neg[0],0], X[neg[0],1], 'bo')
plt.xlim([min(X[:,0]),max(X[:,0])])
plt.ylim([min(X[:,1]),max(X[:,1])])

logreg = linear_model.LogisticRegression(C=1)


h = .02  # step size in the mesh

# we fit the data.
logreg.fit(X, y)

score= logreg.score(X, y)

# Plot the decision boundary. For that, we will assign a color to each
# point in the mesh [x_min, x_max]x[y_min, y_max].
x_min, x_max = X[:, 0].min() - .5, X[:, 0].max() + .5
y_min, y_max = X[:, 1].min() - .5, X[:, 1].max() + .5
xx, yy = np.meshgrid(np.arange(x_min, x_max, h), np.arange(y_min, y_max, h))

# Ravel() return a contiguous flattened array.
# Predict the color for each x,y point
Z = logreg.predict(np.c_[xx.ravel(), yy.ravel()])

# Put the result into a color plot. Reshape point to xx format
Z = Z.reshape(xx.shape)

# figure(Num = our figure number, figsize=(1,1)) creates an inch-by-inch image
plt.figure(1, figsize=(4, 3))
plt.pcolormesh(xx, yy, Z, cmap=plt.cm.Paired, shading='auto')


plt.show()