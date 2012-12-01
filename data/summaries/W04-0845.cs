(This was also the approach taken by (Gildea and Jurafsky, 2002)).
J02-3001
The SRL task in Senseval-3 used the Framenet (Baker et al., 1998) corpus: given a sentence instance from the corpus, a system’s job would be to identify the phrase constituents and their corresponding role.
P98-1013
Head word (and its part-of-speech tag) of the constituent — After POS tagging, a syntactic parser (Collins, 1997) was then used to obtain the parse tree for the sentence.
P97-1003
In addition to the above features, we also extracted a set of features which required the use of some statistical NLP tools: Transitivity and voice of the target word — The sentence was first part-of-speech tagged and chunked with the fnTBL transformationbased learning tools (Ngai and Florian, 2001).
N01-1006
The features that we used for each sample have been previously shown to be helpful for the SRL task (Gildea and Jurafsky, 2002).
J02-3001
Recall Attempted Single Model 0.764 0.682 89.2% Baseline 0.444 0.396 89.2% Table 4: SNOW Models: Validation Set Results 3.5 Decision Lists The final individual system was a decision list implementation contributed from the Swarthmore College team (Wicentowski et al., 2004), which participated in some of the lexical sample tasks.
W04-0862
The same system also participated in the Senseval-3 lexical sample tasks for Chinese and English, as well as the Multilingual lexical sample task (Carpuat et al., 2004).
W04-0822
Like the boosting model, the maximum entropy system also participated in the Senseval-3 lexical sample tasks for Chinese and English, as well as the Multilingual lexical sample task (Carpuat et al., 2004).
W04-0822
