# -*- coding: utf-8 -*-
"""
Created on Wed Dec 4 21:16:37 2019

@author: sila
"""

from sklearn import datasets
from sklearn.cluster import KMeans  # This will be used for the algorithm
import matplotlib.pyplot as plt
import pandas as pd
import numpy as np

iris_df = datasets.load_iris()

# Features
print(iris_df.feature_names)

# Targets
print(iris_df.target)

# Target Names
print(iris_df.target_names)

# Store the inputs as a Pandas Dataframe and set the column names
x = pd.DataFrame(iris_df.data)
x.columns = ['Sepal_Length', 'Sepal_Width', 'Petal_Length', 'Petal_Width']

y = pd.DataFrame(iris_df.target)
y.columns = ['Targets']

# Set the size of the plot
plt.figure(figsize=(14, 7))

# create color map
colormap = np.array(['red', 'lime', 'black', 'blue', 'yellow', 'green', 'red'])

# Plot Sepal
plt.subplot(1, 2, 1)
plt.scatter(x.Sepal_Length, x.Sepal_Width, c=colormap[y.Targets], s=40)
plt.title('Sepal')

plt.subplot(1, 2, 2)
plt.scatter(x.Petal_Length, x.Petal_Width, c=colormap[y.Targets], s=40)
plt.title('Petal')

plt.show()

x_sepal = x[['Sepal_Length', 'Sepal_Width']]
x_petal = x[['Petal_Length', 'Petal_Width']]

k = 2
# running kmeans clustering into two
kmeans = KMeans(n_clusters=k, random_state=0).fit(x_petal)

# the random state is optionlly, here it is specified so we get determistic clusters.
# this will contain the labels for our predicted clusters (either 0 or 1)
labels = kmeans.labels_
# the centers of the calculated clusters
clusters = kmeans.cluster_centers_
# printing our cluster centers - there will be 2 of them.
print(clusters)

# Plot the Original Classifications
plt.subplot(1, 2, 1)
plt.scatter(x.Petal_Length, x.Petal_Width, c=colormap[y.Targets], s=40)
plt.title('Real Classification')

# Plot the Models Classifications
plt.subplot(1, 2, 2)
plt.scatter(x.Petal_Length, x.Petal_Width, c=colormap[labels], s=40)
plt.title('K Mean Classification')

plt.show()