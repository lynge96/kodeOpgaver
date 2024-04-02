# Titanic dataset predictions

# import panda library and a few others we will need.
import pandas as pd
import matplotlib.pyplot as plt
import seaborn as sns
from sklearn.preprocessing import StandardScaler
from sklearn.model_selection import train_test_split  # Import train_test_split function
from sklearn.ensemble import RandomForestClassifier, RandomForestRegressor  # Import Random Forest Classifier
from sklearn.metrics import classification_report, confusion_matrix
from sklearn.preprocessing import LabelEncoder

def impute_missing_age(data):
    # Separate data into two sets: one with missing 'Age' values and one with non-missing 'Age' values
    data_missing_age = data[data['Age'].isnull()]
    data_non_missing_age = data[data['Age'].notnull()]

    # Define features and target
    features = ['Pclass', 'Sex', 'SibSp', 'Parch', 'Fare']  # Features used for prediction
    target = 'Age'  # Target variable to predict

    # Label encode categorical variables
    label_encoder = LabelEncoder()
    data_non_missing_age['Sex'] = label_encoder.fit_transform(data_non_missing_age['Sex'])
    data_missing_age['Sex'] = label_encoder.transform(data_missing_age['Sex'])

    # Train a regression model to predict 'Age' based on other features
    rf_model = RandomForestRegressor(n_estimators=100, random_state=42)
    rf_model.fit(data_non_missing_age[features], data_non_missing_age[target])

    # Predict 'Age' for missing values using the trained model
    predicted_age = rf_model.predict(data_missing_age[features])

    # Replace missing 'Age' values with predicted values
    data_missing_age.loc[:, target] = predicted_age

    # Concatenate data with imputed 'Age' values and data with non-missing 'Age' values
    data_imputed_age = pd.concat([data_non_missing_age, data_missing_age], axis=0)

    return data_imputed_age


# skipping the header
data = pd.read_csv('titanic_800.csv', sep=',', header=0)
data = impute_missing_age(data)

# Remove 'Cabin', 'Name', and 'Ticket' columns from the data
columns_to_drop = ['Cabin', 'Name', 'Ticket']
data.drop(columns_to_drop, axis=1, inplace=True)

# Define custom mapping dictionary
embarked_mapping = {'C': 0, 'Q': 1, 'S': 2}

# Map 'Embarked' values to numerical values using the custom mapping
data['Embarked'] = data['Embarked'].map(embarked_mapping)

# Handling missing values for 'Pclass' and 'Survived' columns
data['Pclass'].fillna(3, inplace=True)
data['Survived'].fillna(1, inplace=True)

# Drop 'PassengerId' column as it's not useful for prediction
data.drop('PassengerId', axis=1, inplace=True)

# Round the 'Fare' and 'Age' columns to 2 decimal places
data['Fare'] = data['Fare'].round(2)
data['Age'] = data['Age'].round(2)

print(data)

# Extract the target variable 'Survived' into yvalues DataFrame
yvalues = pd.DataFrame(data["Survived"].copy(), columns=["Survived"])

# Visualize the data
x = data["Age"]
y = data["Pclass"]
plt.figure()
plt.scatter(x.values, y.values, color='black', s=20)
plt.xlabel('Age')
plt.ylabel('Pclass')
plt.title('Scatter plot of Age vs Pclass')
plt.show()

# Drop 'Survived' column from the data
data.drop('Survived', axis=1, inplace=True)

# Split data into training and testing sets
xtrain, xtest, ytrain, ytest = train_test_split(data, yvalues, test_size=0.1, random_state=42)

# Scale feature data
scaler = StandardScaler()
xtrain_scaled = scaler.fit_transform(xtrain)
xtest_scaled = scaler.transform(xtest)

# Instantiate the Random Forest Classifier
rf_classifier = RandomForestClassifier(n_estimators=100, random_state=1)

# Train the Random Forest Classifier using the training data
rf_classifier.fit(xtrain_scaled, ytrain.values.ravel())

# Predictions
predictions = rf_classifier.predict(xtest_scaled)

# Replace class labels 0 and 1 with 'died' and 'survived'
ytest_labels = ytest.replace({0: 'died', 1: 'survived'})
predictions_labels = pd.Series(predictions).replace({0: 'died', 1: 'survived'})

# Confusion matrix and classification report
matrix = confusion_matrix(ytest_labels, predictions_labels)
print(matrix)
print(classification_report(ytest_labels, predictions_labels))

# Convert confusion matrix to DataFrame for better visualization
confusion_df = pd.DataFrame(matrix, index=['Actual Died', 'Actual Survived'], columns=['Predicted Died', 'Predicted Survived'])

# Plot confusion matrix as a heatmap
plt.figure(figsize=(8, 6))
sns.heatmap(confusion_df, annot=True, cmap='Blues', fmt='d')
plt.title('Confusion Matrix')
plt.xlabel('Predicted label')
plt.ylabel('True label')
plt.show()

feature_importance = pd.Series(rf_classifier.feature_importances_, index=data.columns)
feature_importance.nlargest(10).plot(kind='barh')
plt.title('Most Important Features')
plt.xlabel('Relative Importance')
plt.ylabel('Feature')
plt.show()

