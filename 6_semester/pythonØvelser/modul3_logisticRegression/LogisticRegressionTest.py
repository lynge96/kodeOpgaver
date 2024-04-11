# Import necessary libraries
import numpy as np
import pandas as pd
from sklearn.model_selection import train_test_split
from sklearn.linear_model import LogisticRegression
from sklearn.metrics import accuracy_score, classification_report, confusion_matrix

# Create a hypothetical dataset
np.random.seed(42)
data = {
    'feature1': np.random.rand(100),
    'feature2': np.random.rand(100),
    'target': np.random.choice([0, 1], size=100)
}
df = pd.DataFrame(data)

# Split the dataset into features (X) and target variable (y)
X = df[['feature1', 'feature2']]
y = df['target']

# Split the dataset into training and testing sets
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=42)

# Create and train a logistic regression model
logreg_model = LogisticRegression()
logreg_model.fit(X_train, y_train)

# Make probability predictions on the test set
probabilities = logreg_model.predict_proba(X_test)[:, 1]

# Set a threshold for binary predictions (e.g., 0.5)
threshold = 0.5

# Convert probability predictions into binary predictions
binary_predictions = (probabilities >= threshold).astype(int)

# Evaluate the model
accuracy = accuracy_score(y_test, binary_predictions)
conf_matrix = confusion_matrix(y_test, binary_predictions)
classification_rep = classification_report(y_test, binary_predictions)

# Print results
print(f"Threshold: {threshold}")
print(f"Binary Predictions: {binary_predictions}")
print(f"Accuracy: {accuracy}")
print("Confusion Matrix:\n", conf_matrix)
print("Classification Report:\n", classification_rep)
