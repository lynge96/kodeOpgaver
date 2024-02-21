# -*- coding: utf-8 -*-
"""
Created on Thu Apr 19 11:12:43 2018

@author: Sila
"""

import numpy as np

from sklearn.datasets import load_iris
iris_dataset = load_iris()

# Split the data
from sklearn.model_selection import train_test_split
X_train, X_test, Y_train, Y_test = train_test_split(iris_dataset['data'], iris_dataset['target'], random_state=0)

# random_state simply sets a seed to the random generator,
# so that your train-test splits are always deterministic.
# If you don't set a seed, it is different each time.

# Prepare the classifier
from sklearn.linear_model import LogisticRegression
logreg = LogisticRegression(C=1.0, class_weight=None, dual=False, fit_intercept=True,
          intercept_scaling=1, max_iter=1000000, multi_class='ovr', n_jobs=1,
          penalty='l2', random_state=None, solver='liblinear', tol=0.0001,
          verbose=0, warm_start=False)

# Fit the model
logreg.fit(X_train, Y_train)

# Evaluate the model
print("Training scores: {:.2f}".format(logreg.score(X_train, Y_train)))
print("Test scores: {:.2f}".format(logreg.score(X_test,Y_test)))

#Training scores: 0.95
#Test scores: 0.87

#Not bad! But 87% is still not 100 %...

#The training is so good that there may be overfitting.
# Since this model uses L2 regularization, let's adjust the C parameter...

logreg = LogisticRegression(C=0.01, class_weight=None, dual=False, fit_intercept=True,
          intercept_scaling=1, max_iter=1000000, multi_class='ovr', n_jobs=1,
          penalty='l2', random_state=None, solver='liblinear', tol=0.0001,
          verbose=0, warm_start=False)

# Fit the model
logreg.fit(X_train, Y_train)

# Evaluate the model
print("Training scores: {:.2f}".format(logreg.score(X_train, Y_train)))
print("Test scores: {:.2f}".format(logreg.score(X_test,Y_test)))

#Training scores: 0.70
# Test scores: 0.58

# Not a good idea...

# Maybe it wasn't overfit with this data.
# Lets try raising the C param instead.

logreg = LogisticRegression(C = 2, max_iter=1000000,).fit(X_train, Y_train)

# Evaluate the model
print("Training scores: {:.2f}".format(logreg.score(X_train, Y_train)))
print("Test scores: {:.2f}".format(logreg.score(X_test,Y_test)))

#Training scores: 0.98
#Test scores: 0.97

# Better! Lets give it another nudge.
logreg = LogisticRegression(C = 99999, max_iter=1000000).fit(X_train, Y_train)

# Evaluate the model
print("Training scores: {:.2f}".format(logreg.score(X_train, Y_train)))
print("Test scores: {:.2f}".format(logreg.score(X_test,Y_test)))

#Training scores: 1.00
#"Test scores: 0.97

# Nice