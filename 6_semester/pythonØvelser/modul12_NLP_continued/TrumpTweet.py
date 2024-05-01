# -*- coding: utf-8 -*-
"""
Created on Wed May 6 12:49:17 2020
@author: Sila
"""

import spacy
nlp = spacy.load('en_core_web_sm')
from collections import Counter

with open('TrumpBig.txt','r',encoding='utf-8') as f:
    doc = nlp(f.read())

print("How many tweet sentences are we looking at:")
print(len([sent for sent in doc.sents]))

print("In how many of these sentences can we find entities:")
list_of_sents = [nlp(sent.text) for sent in doc.sents]
list_of_ners = [doc for doc in list_of_sents if doc.ents]
print(len(list_of_ners))

#Stopwords:
#for token in doc:
#    if token.is_stop:
#       print (token)

# Remove stop words and punctuation symbols
words = [token.text for token in doc
             if not token.is_stop and not token.is_punct]

word_freq = Counter(words)
print("Commonly occurring words with their frequencies:")
common_words = word_freq.most_common(20)
print(common_words)

# Unique words
print("Unique words only occuring once:")
unique_words = [word for (word, freq) in word_freq.items() if freq == 1]
print (unique_words)

nouns = []
adjectives = []
for token in doc:
   if token.pos_ == 'NOUN':
       nouns.append(token)
   if token.pos_ == 'ADJ':
       adjectives.append(token)

print("Tweet Nouns:")
print(nouns)
nouns= [token.text for token in doc
             if token.pos_ == 'NOUN' and not token.is_stop and not token.is_punct]
nouns_freq = Counter(nouns)
print("Commonly occurring nouns with their frequencies:")
nouns_common_words = nouns_freq.most_common(10)
print(nouns_common_words)

print("Tweet Adjectives:")
print(adjectives)
adjectives= [token.text for token in doc
             if token.pos_ == 'ADJ' and not token.is_stop and not token.is_punct]
adjectives_freq = Counter(adjectives)
print("Commonly occurring adjectives with their frequencies:")
common_words = adjectives_freq.most_common(10)
print(common_words)

#for ent in doc.ents:
#    print(ent.text, ent.label_, spacy.explain(ent.label_))

tweet_entities = [ent.text for ent in doc.ents]
tweet_entities_freq = Counter(tweet_entities)
print("Commonly occurring Entities with their frequencies:")
common_words = tweet_entities_freq.most_common(10)
print(common_words)