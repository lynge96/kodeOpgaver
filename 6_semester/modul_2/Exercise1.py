import matplotlib.pyplot as plt

# Points with x and y coordinates
points = [(2, 5), (3, 8), (5, 11), (7, 14), (9, 17),
          (11, 20), (13, 23), (15, 26), (17, 29), (19, 32),
          (21, 35), (23, 38), (25, 41), (27, 44), (29, 47),
          (31, 50), (33, 53), (35, 56), (37, 59), (39, 62)]

# Separate x and y coordinates
x_values, y_values = zip(*points)

# Create a scatter plot
plt.scatter(x_values, y_values, color='blue', label='Data Points')

# Add labels and title
plt.xlabel('X-axis')
plt.ylabel('Y-axis')
plt.title('Scatter Plot of Data Points')

# Display the plot
plt.legend()
plt.grid(True)
plt.show()
