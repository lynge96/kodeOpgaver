# -*- coding: utf-8 -*-
"""
Created on Mon February 19 16:10:21 2024

@author: sila
"""

import pandas
from sklearn import tree
from sklearn.tree import DecisionTreeClassifier, export_graphviz
import matplotlib.pyplot as plt
import matplotlib.image as pltimg

df = pandas.read_csv("shows.csv")

print(df)

# To make a decision tree, all data has to be numerical.
# We have to convert the non numerical columns 'Nationality' and 'Go' into numerical values.
# Pandas has a map() method that takes a dictionary with information on how to convert the values.
# {'UK': 0, 'USA': 1, 'N': 2}
# Means convert the values 'UK' to 0, 'USA' to 1, and 'N' to 2.
# Example
# Change string values into numerical values:
d = {'UK': 0, 'USA': 1, 'N': 2}
df['Nationality'] = df['Nationality'].map(d)
d = {'YES': 1, 'NO': 0}
df['Go'] = df['Go'].map(d)

features = ['Age', 'Experience', 'Rank', 'Nationality']

X = df[features]
y = df['Go']

# The feature columns are the columns that we try to predict from,
# and the target column is the column with the values we try to predict.
# Example
# X is the feature columns:
features = ['Age', 'Experience', 'Rank', 'Nationality']
X = df[features]
print(X)

# y is the target column:
y = df['Go']
print(y)

# Now we can create the actual decision tree, fit it with our details, and save a .png file on the computer:
# Example
# Create a Decision Tree, save it as an image, and show the image:
import graphviz
dtree = tree.DecisionTreeClassifier() # random_state = 1, max_depth = 7, min_samples_split=2

dtree = DecisionTreeClassifier()
dtree = dtree.fit(X, y)

import pydotplus
from six import StringIO
import matplotlib.image as mpimg
import io

dot_data = io.StringIO()

export_graphviz(dtree,
                out_file=dot_data, # or put a filename here filename like "graph.dot", you then need to convert it into pgn
                feature_names=features,
                rounded=True,
                filled=True)

filename = "tree.png"
pydotplus.graph_from_dot_data(dot_data.getvalue()).write_png(filename) # write the dot data to a pgn file
img=mpimg.imread(filename) # read this pgn file

plt.figure(figsize=(8,8)) # setting the size to 10 x 10 inches of the figure.
imgplot = plt.imshow(img) # plot the image.
plt.show()

print(dtree.predict([[40, 10, 6, 1]]))
