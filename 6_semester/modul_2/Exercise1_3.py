import numpy as np
import matplotlib.pyplot as plt
from sklearn.linear_model import LinearRegression

# Generate random data
np.random.seed(42)
X = 2 * np.random.rand(100, 1)
y = 4 + 3 * X + np.random.randn(100, 1)

# Create a linear regression model
model = LinearRegression()
model.fit(X, y)

# Predict the y-values based on the model
y_pred = model.predict(X)

# Create a scatter plot of the generated data
plt.scatter(X, y, color='blue', label='Generated Data')

# Plot the regression line
plt.plot(X, y_pred, color='red', linewidth=2, label='Linear Regression Line')

# Add labels and title
plt.xlabel('X-axis')
plt.ylabel('Y-axis')
plt.title('Scatter Plot with Linear Regression Line')

# Display the plot
plt.legend()
plt.grid(True)
plt.show()
