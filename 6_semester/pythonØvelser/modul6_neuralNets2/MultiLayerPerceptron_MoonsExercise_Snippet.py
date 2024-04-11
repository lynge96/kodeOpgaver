# -*- coding: utf-8 -*-
"""
Created on Wed Sep 29 17:04:39 2021

@author: sila
"""

#This is a short example of using a MLpClassifier to predict data.
# Here using a Neural Net to predict datapoints from the Moons dataset.

#First we will import the data and just visualize them to get an idea of how it looks.

import matplotlib.pyplot as plt
from sklearn.datasets import make_moons;
from pandas import DataFrame
# generate 2d classification dataset
X, y = make_moons(n_samples=400, noise=0.2)
# scatter plot, dots colored by class value
df = DataFrame(dict(x=X[:,0], y=X[:,1], label=y))
colors = {0:'red', 1:'blue'}
fig, ax = plt.subplots()
grouped = df.groupby('label')
for key, group in grouped:
    group.plot(ax=ax, kind='scatter', x='x', y='y', label=key, color=colors[key])

plt.show()


--- here ----

--- iNSERT yOUR OWN CODE ---

---- tO TRAIN ----

---- And VISUALIZE --  MESH PLOT ---

---- For inspiration, see code examples from earlier weeks ----