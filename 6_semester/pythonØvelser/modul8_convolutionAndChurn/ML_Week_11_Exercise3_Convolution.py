# -*- coding: utf-8 -*-
"""
Created on Wed Nov 15 15:41:07 2021

@author: sila
"""

# Convolutions in Tensorflow.
# Example p. 453 in Hands on Machine Learning by Aurelien Geron

import numpy as np
from sklearn.datasets import load_sample_image
import tensorflow as tf

import matplotlib.pyplot as plt

# load sample images
china = load_sample_image("china.jpg") / 255
flower = load_sample_image("flower.jpg") / 255

images = np.array([china, flower])
batch_size, height, width, channels = images.shape

# create 2 filters, 7 x 7.
filters = np.zeros(shape=(7, 7, channels, 2), dtype=np.float32)
filters[:, 3, :, 0] = 1  # vertical line
filters[3, :, :, 1] = 1  # horisontal line

# print(filters)

outputs = tf.nn.conv2d(images, filters, strides=10, padding="SAME")

plt.imshow(outputs[0, :, :, 1])  # plot 1st image 2 feature map
plt.show()
