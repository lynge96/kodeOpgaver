import numpy as np
import matplotlib.pyplot as plt

# Generate random data
np.random.seed(42)  # Set seed for reproducibility
X = 2 * np.random.rand(100, 1)
y = 4 + 3 * X + np.random.randn(100, 1)

# Create a scatter plot of the generated data
plt.scatter(X, y, color='blue', label='Generated Data')

# Add labels and title
plt.xlabel('X-axis')
plt.ylabel('Y-axis')
plt.title('Scatter Plot of Generated Data')

# Display the plot
plt.legend()
plt.grid(True)
plt.show()
