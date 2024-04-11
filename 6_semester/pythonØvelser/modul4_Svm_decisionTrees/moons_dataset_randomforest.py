# -*- coding: utf-8 -*-
"""
Created on Wed Apr 14 11:23:02 2018

@author: sila
"""

from sklearn.datasets import make_moons;
from sklearn.ensemble import RandomForestClassifier
import matplotlib.pyplot as plt

from matplotlib import pyplot
from pandas import DataFrame
# generate 2d classification dataset
X, y = make_moons(n_samples=1000, noise=0.1)
# scatter plot, dots colored by class value
df = DataFrame(dict(x=X[:,0], y=X[:,1], label=y))
colors = {0:'red', 1:'blue'}
fig, ax = pyplot.subplots()
grouped = df.groupby('label')
for key, group in grouped:
    group.plot(ax=ax, kind='scatter', x='x', y='y', label=key, color=colors[key])

pyplot.show()


from sklearn.model_selection import train_test_split

xtrain, xtest, ytrain, ytest = train_test_split(X, y, test_size=0.20)

accuracy = []
error = []
# training - with different number of trees - from 1 til 70
for i in range(1,10):
    clf = RandomForestClassifier(n_estimators=i)
    clf.fit(xtrain, ytrain)
    acc= clf.score(xtest, ytest)
    accuracy.append(acc)

plt.figure(figsize=(8,8))
plt.plot(accuracy,label='Accuracy')
plt.legend()
plt.title("RandomForest training - different number of trees")
plt.xlabel("Number of Trees used")
plt.show()


