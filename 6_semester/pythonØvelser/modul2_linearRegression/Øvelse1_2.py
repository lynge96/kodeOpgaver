import matplotlib.pyplot as plt
import numpy as np

X = 2 * np.random.rand(100, 1)
y = 4 + 3 * X + np.random.randn(100, 1)

# Combine X and y using zip
coordinates = list(zip(X, y))

# Print the coordinates
for count, (x_coord, y_coord) in enumerate(coordinates, start=1):
    print(f"{count} x-coordinate: {x_coord}, y-coordinate: {y_coord}")

plt.plot(X, y, "g.")
plt.axis([0, 2, 0, 15])
plt.plot()
plt.show()
