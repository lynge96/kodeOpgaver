# Spring 2022
# PBA. Ai And Automation. Eaaa.
# Sila.

# Hands on NLP with Python
# Rajesh Arumugam and Rajalingappaa Shanmugamani

'''Tweeet sentiment analysis based on BOW.
(Where) Bag-of-words is a vector representation
of text. Each of the vector dimensions captures either the frequency, presence or absence, or
weighted values of words in the text. A bag-of-words representation does not capture the
order of the words.'''

import random
import nltk
nltk.download('twitter_samples')
from nltk.corpus import twitter_samples
from sklearn.feature_extraction.text import TfidfVectorizer
from sklearn.feature_extraction.text import CountVectorizer
from sklearn.model_selection import train_test_split
from sklearn.ensemble import RandomForestClassifier
from sklearn.metrics import accuracy_score
from sklearn.metrics import confusion_matrix

pos_tweets = [(string, 1) for string in twitter_samples.strings('positive_tweets.json')]
neg_tweets = [(string,0) for string in twitter_samples.strings('negative_tweets.json')]
pos_tweets.extend(neg_tweets)
comb_tweets = pos_tweets
random.shuffle(comb_tweets)
tweets,labels = (zip(*comb_tweets))

count_vectorizer = CountVectorizer(ngram_range=(1,2),max_features=10000)
X = count_vectorizer.fit_transform(tweets)

print("Split dataset into training and test set")
X_train,X_test,y_train,y_test = train_test_split(X,labels,test_size=0.2,random_state=10)

print("Use Randomforest to classify")
rf = RandomForestClassifier(n_estimators=100,n_jobs=4,random_state=10)
rf.fit(X_train,y_train)

print("Predict sentiment on Tweets in test set")
preds = rf.predict(X_test)
print(accuracy_score(y_test,preds))
print(confusion_matrix(y_test,preds))