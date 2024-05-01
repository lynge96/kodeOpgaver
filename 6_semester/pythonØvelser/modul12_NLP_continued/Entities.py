# -*- coding: utf-8 -*-
"""
Created on Mon Apr 27 18:53:11 2020
@author: Sila
"""

import spacy

# spaCy keeps the spaces too
nlp = spacy.load('en_core_web_sm')
doc = nlp('Hello     World!')
for token in doc:
    print('"' + token.text + '"')

# Find entities in a sentence
#Doing NER with spaCy is super easy and the pretrained model performs pretty well

print()
print("Find entities in a sentence:")
doc = nlp("Next week I'll be in Madrid.")
for ent in doc.ents:
    print(ent.text, ent.label_)

# Next week DATE
# Madrid GPE

print()
print("Find entities in a sentence:")
doc = nlp("I just bought 2 shares at 9 a.m. because the stock went up 30% in just 2 days according to the WSJ")
for ent in doc.ents:
    print(ent.text, ent.label_)