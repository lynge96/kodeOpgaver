import pandas as pd
import numpy as np
import seaborn as sns
import matplotlib.pyplot as plt
from sklearn.model_selection import train_test_split
from sklearn.preprocessing import StandardScaler
from sklearn.linear_model import LogisticRegression
from sklearn.ensemble import RandomForestClassifier, GradientBoostingClassifier
from sklearn.metrics import accuracy_score, classification_report, confusion_matrix

# Load the data with the correct separator
data = pd.read_csv('studentchurn.csv', sep=';')

# Print the DataFrame to check its structure
print(data.head())

# Convert non-numeric data to numeric format
data['Churn'] = data['Churn'].replace({'Completed': 1, 'Stopped': 0}).infer_objects()
data['Line'] = pd.factorize(data['Line'])[0] + 1  # Encode categorical variable as numeric

# Handle missing or non-finite values in 'StudyGroup' column
data['StudyGroup'] = pd.to_numeric(data['StudyGroup'], errors='coerce')  # Convert to numeric, setting errors to 'coerce' will replace non-finite values with NaN
data.dropna(subset=['StudyGroup'], inplace=True)  # Drop rows with NaN values in 'StudyGroup'

# Drop the 'Id' column
data.drop(columns=['Id'], inplace=True)

# Splitting the data into features (X) and target variable (y)
X = data.drop(columns=['Churn'])
y = data['Churn']

# Feature scaling
scaler = StandardScaler()
X_scaled = scaler.fit_transform(X)

# Splitting the scaled data into training and testing sets
X_train, X_test, y_train, y_test = train_test_split(X_scaled, y, test_size=0.1, random_state=42)

# Instantiate and train the logistic regression model
logistic_model = LogisticRegression()
logistic_model.fit(X_train, y_train)

# Predictions on the test set using logistic regression
y_pred_logistic = logistic_model.predict(X_test)

# Evaluate performance of logistic regression
accuracy_logistic = accuracy_score(y_test, y_pred_logistic)
print("Logistic Regression Accuracy:", accuracy_logistic)
print("Logistic Regression Classification Report:")
print(classification_report(y_test, y_pred_logistic))
print("Logistic Regression Confusion Matrix:")
print(confusion_matrix(y_test, y_pred_logistic))

# Instantiate and train the random forest classifier
random_forest_model = RandomForestClassifier(random_state=42)
random_forest_model.fit(X_train, y_train)

# Predictions on the test set using random forest
y_pred_rf = random_forest_model.predict(X_test)

# Evaluate performance of random forest
accuracy_rf = accuracy_score(y_test, y_pred_rf)
print("\nRandom Forest Accuracy:", accuracy_rf)
print("Random Forest Classification Report:")
print(classification_report(y_test, y_pred_rf))
print("Random Forest Confusion Matrix:")
print(confusion_matrix(y_test, y_pred_rf))

# Instantiate and train the gradient boosting classifier
gradient_boosting_model = GradientBoostingClassifier(random_state=42)
gradient_boosting_model.fit(X_train, y_train)

# Predictions on the test set using gradient boosting
y_pred_gb = gradient_boosting_model.predict(X_test)

# Evaluate performance of gradient boosting
accuracy_gb = accuracy_score(y_test, y_pred_gb)
print("\nGradient Boosting Accuracy:", accuracy_gb)
print("Gradient Boosting Classification Report:")
print(classification_report(y_test, y_pred_gb))
print("Gradient Boosting Confusion Matrix:")
print(confusion_matrix(y_test, y_pred_gb))

# Plotting the confusion matrix heatmap for logistic regression
plt.figure(figsize=(6, 4))
sns.heatmap(confusion_matrix(y_test, y_pred_logistic), annot=True, cmap='Blues', fmt='g', xticklabels=['Predicted No', 'Predicted Yes'], yticklabels=['Actual No', 'Actual Yes'])
plt.xlabel('Predicted Label')
plt.ylabel('True Label')
plt.title('Logistic Regression Confusion Matrix')
plt.show()

# Plotting the confusion matrix heatmap for random forest
plt.figure(figsize=(6, 4))
sns.heatmap(confusion_matrix(y_test, y_pred_rf), annot=True, cmap='Blues', fmt='g', xticklabels=['Predicted No', 'Predicted Yes'], yticklabels=['Actual No', 'Actual Yes'])
plt.xlabel('Predicted Label')
plt.ylabel('True Label')
plt.title('Random Forest Confusion Matrix')
plt.show()

# Plotting the confusion matrix heatmap for gradient boosting
plt.figure(figsize=(6, 4))
sns.heatmap(confusion_matrix(y_test, y_pred_gb), annot=True, cmap='Blues', fmt='g', xticklabels=['Predicted No', 'Predicted Yes'], yticklabels=['Actual No', 'Actual Yes'])
plt.xlabel('Predicted Label')
plt.ylabel('True Label')
plt.title('Gradient Boosting Confusion Matrix')
plt.show()

print("Number of rows in training set:", X_train.shape[0])
print("Number of rows in test set:", X_test.shape[0])
