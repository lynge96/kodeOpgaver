# -*- coding: utf-8 -*-
"""
Created on Mon Apr 27 20:11:14 2020
@author: Sila
"""

import spacy

#Loads the model .. takes a while
nlp = spacy.load('en_core_web_md')
#Print vector for banana
print(nlp.vocab['banana'].vector)

from scipy import spatial

cosine_similarity = lambda x, y: 1 - spatial.distance.cosine(x, y)

man = nlp.vocab['man'].vector
woman = nlp.vocab['woman'].vector
queen = nlp.vocab['queen'].vector
king = nlp.vocab['king'].vector

# We now need to find the closest vector in the vocabulary to the result of "man" - "woman" + "queen"
maybe_king = man - woman + queen
computed_similarities = []

# lets find words that are close to maybe_king
print("lets find words that are close to maybe_king")
for word in nlp.vocab:
    # Ignore words without vectors
    if not word.has_vector:
        continue

    similarity = cosine_similarity(maybe_king, word.vector)
    computed_similarities.append((word, similarity))

computed_similarities = sorted(computed_similarities, key=lambda item: -item[1])
print([w[0].text for w in computed_similarities[:10]])

# ['Queen', 'QUEEN', 'queen', 'King', 'KING', 'king', 'KIng', 'KINGS', 'kings', 'Kings']

maybe_queen = king - man + woman
computed_similarities = []

# lets find words that are close to maybe_king
print("lets find words that are close to maybe_queen")
for word in nlp.vocab:
    # Ignore words without vectors
    if not word.has_vector:
        continue

    similarity = cosine_similarity(maybe_queen, word.vector)
    computed_similarities.append((word, similarity))

computed_similarities = sorted(computed_similarities, key=lambda item: -item[1])
print([w[0].text for w in computed_similarities[:10]])

# ['King', 'KING', 'king', 'KIng', 'Queen', 'QUEEN', 'queen', 'Prince', 'commoner', 'highness']

dog = nlp.vocab['dog'].vector
puppy = nlp.vocab['puppy'].vector
cat = nlp.vocab['cat'].vector
kitten = nlp.vocab['kitten'].vector

# We now need to find the closest vector in the vocabulary to the result of "man" - "woman" + "queen"
maybe_cat = dog - puppy + kitten
computed_similarities = []

# lets find words that are close to maybe_cat
print("lets find words that are close to maybe_kitten")
for word in nlp.vocab:
    # Ignore words without vectors
    if not word.has_vector:
        continue

    similarity = cosine_similarity(maybe_cat, word.vector)
    computed_similarities.append((word, similarity))

computed_similarities = sorted(computed_similarities, key=lambda item: -item[1])
print([w[0].text for w in computed_similarities[:10]])

# didn't work out so well as two earlier examples ... but well
# ['FELINE', 'Cat', 'feline', 'cat', 'Feline', 'CAT', 'HOUND', 'Kennel', 'DOG', 'kennel']