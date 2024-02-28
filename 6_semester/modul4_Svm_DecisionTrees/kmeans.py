# -*- coding: utf-8 -*-
"""
Created on Wed Apr 11 21:16:37 2018

@author: sila
"""

from sklearn.cluster import KMeans # This will be used for the algorithm

import matplotlib.pyplot as plt  # This will be use to plot the data
from sklearn import datasets   # This will be used to get a sample dataset - just to have some data

iris = datasets.load_iris()

# we only take the first two features. We could avoid this ugly
# slicing by using a real two-dim dataset
# the iris-data is a multidimensional data so we slice the first 
X = iris.data[:, :2]  
# Taking the first two columns - notation array[x,y] gives you the x-th row and the y-column
# if you want all values on the row i.e. an entire column use array[:,columnNr]
print(X) # just to print the data so we can see what we are dealing with

plt.figure() # creating a new figure
plt.scatter(X[:, 0], X[:, 1], color='black', s=20)  # plot x,y values using the color black and size = 20

k = 2 
#running kmeans clustering into two
kmeans = KMeans(n_clusters=k, random_state=0).fit(X)  
# the random state is optionlly, here it is specified so we get determistic clusters.
# this will contain the labels for our predicted clusters (either 0 or 1)   
labels = kmeans.labels_
# the centers of the calculated clusters
clusters = kmeans.cluster_centers_
# printing our cluster centers - there will be 2 of them.
print(clusters)

# need a new import
from matplotlib.colors import ListedColormap

# we define color lists to use with K values from 2 till 5
# the color values are simply RGB values, so the colormap for k = 2, will give red ($FF0000) and green ($00FF00) colors
cmap_bold = [ListedColormap(['#FF0000', '#00FF00']),
             ListedColormap(['#FF0000', '#00FF00', '#0000FF']),
             ListedColormap(['#FF0000', '#00FF00', '#0000FF', '#FFFF00']),
             ListedColormap(['#FF0000', '#00FF00', '#0000FF', '#FFFF00','#00FFFF'])]

# now plot the same points, but this time assigning the colors to indicate the clusters

plt.scatter(X[:, 0], X[:, 1], c=labels, edgecolor='black', cmap=cmap_bold[0], s=20)

print(kmeans.predict([[7, 3], [8, 4]]))



