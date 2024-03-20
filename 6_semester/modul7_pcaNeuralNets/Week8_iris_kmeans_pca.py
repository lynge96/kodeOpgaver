# -*- coding: utf-8 -*-
"""
Created on Wed Dec 4 21:25:37 2019

@author: sila
"""

from sklearn import datasets
from sklearn.cluster import KMeans # This will be used for the algorithm
import matplotlib.pyplot as plt 
import numpy as np
from sklearn.decomposition import PCA

iris_df = datasets.load_iris()

pca = PCA(2)
print (pca)

X, y = iris_df.data, iris_df.target
X_proj = pca.fit_transform(X)
print ( X_proj.shape ) 

plt.scatter(X_proj[:,0], X_proj[:,1],c=y)
plt.show()


#Principal axes in feature space, representing the directions of maximum variance in the data. 
#The components are sorted by explained_variance_.

#pca.components_ has the meaning of each principal component, essentially how it was derived
#checking shape tells us it has 2 rows, one for each principal component and 4 columns, proportion of each of the 4 features
#for each row
print ( pca.components_ )
print ( pca.components_.shape ) 

#this tells us the extent to which each component explains the original dataset.
#so the 1st component is able to explain ~92% of X and the second only about 5.3%
#Together they can explain about 97.3% of the variance of X 

print("Explained_variance_ratio")
print (pca.explained_variance_ratio_)



# Set the size of the plot
plt.figure(figsize=(10,4))
 
# create color map
colormap = np.array(['red', 'lime', 'black', 'blue', 'yellow', 'green', 'red']) 

k = 5 
#running kmeans clustering into two
kmeans = KMeans(n_clusters=k, random_state=0).fit(X_proj)  


# the random state is optionlly, here it is specified so we get determistic clusters.
# this will contain the labels for our predicted clusters (either 0 or 1)   
labels = kmeans.labels_
# the centers of the calculated clusters
clusters = kmeans.cluster_centers_
# printing our cluster centers - there will be 2 of them.
print(clusters)

# Plot the Original Classifications
plt.subplot(1, 2, 1)
plt.scatter(X_proj[:,0], X_proj[:,1], c=colormap[y], s=40)
plt.title('Real Classification')
 
# Plot the Models Classifications
plt.subplot(1, 2, 2)
plt.scatter(X_proj[:,0], X_proj[:,1], c=colormap[labels], s=40)
plt.title('K Mean Classification')

plt.show();