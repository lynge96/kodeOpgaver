# -*- coding: utf-8 -*-
"""
Created on Mon Apr 27 16:11:14 2020
@author: Sila
"""

import nltk
nltk.download('state_union')
nltk.download('brown')
from nltk.corpus import state_union
from matplotlib import pyplot


print("Distribution of words men and women in the state of the Union per year")
print(state_union.fileids())
#cfd for inaugral address speeches for each president showing count of words american and citizen each speech
cfd = nltk.ConditionalFreqDist((target,fileid[:4])for fileid in state_union.fileids() for w in state_union.words(fileid) for target in  ['men','women'] if w.lower().startswith(target))
cfd.plot()

print("Common words with two different domains of text")
from nltk.corpus import brown
print("Categories")
print(brown.categories())
news_data=brown.words(categories='news')
religion_data=brown.words(categories='religion')

news_data = nltk.Text(news_data)
religion_data = nltk.Text(religion_data)
#trying to find common words. Frequency of news_data and religion_data.
news_fd = nltk.FreqDist(news_data)
religion_fd = nltk.FreqDist(religion_data)
print(news_fd)
print(religion_fd)
print()
print(news_data.concordance('state'))
print()
print(religion_data.concordance('state'))