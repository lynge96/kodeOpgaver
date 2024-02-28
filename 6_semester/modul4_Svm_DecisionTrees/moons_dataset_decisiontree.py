# -*- coding: utf-8 -*-
"""
Created on Wed Apr 11 11:32:45 2018

@author: sila
"""

from sklearn.datasets import make_moons;
from sklearn.tree import DecisionTreeClassifier

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

tree_clf = DecisionTreeClassifier(max_depth=2) ## indicate we do not want the tree to be deeper than 2 levels
tree_clf.fit(xtrain, ytrain) # training the classifier


accuracy = []
error = []

acc= tree_clf.score( xtest, ytest)
accuracy.append(acc)
print(accuracy)

print("probability of point = (0.25,-0.5) = "+str(tree_clf.predict_proba([[0.25,-0.5]])))
print("probability of point = (1.5,-05) = "+str(tree_clf.predict_proba([[1.5,-0.5]])))
print("probability of point = (-1,1) =  "+str(tree_clf.predict_proba([[-1,1]])))