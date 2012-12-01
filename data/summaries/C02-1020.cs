(Sato and Nakanishi, 1998) has proposed a method for learning a probabilistic translation model with Maximum Entropy (ME) modeling which was the same approach of the statistical machine learning as SVMs, in which co-occurrence information and morphological information were used as features and has archived 58.25 % accuracy with 4,119 features.
P98-2191
(Fung, 1997) has calculated the vectors in which the weighted mutual information between the word in the corpora and the word included in an existing translation dictionary was an element, and has used these inner products as the correspondence level of word pairs.
W97-0119
Therefore, researches of extracting translation pairs from parallel corpora automatically become active recently (Gale and Church, 1991; Kaji and Aizono, 1996; Tanaka and Iwasaki, 1996; Kitamura and Matsumoto, 1996; Fung, 1997; Melamed, 1997; Sato and Nakanishi, 1998).
C96-1006 H91-1026 P97-1063 P98-2191 W96-0107 W97-0119
They are based on the idea that the context of the words which appear in neighborhood looks like each other for the translation pairs although expressed in the two di erent languages (Kaji and Aizono, 1996).
C96-1006
Therefore, SVMs have been recently used for the natural language processing such as text categorization (Joachims, 1998; Taira and Haruno, 1999), chunk identification (Kudo and Matsumoto, 2000b), dependency structure analysis (Kudo and Matsumoto, 2000a).
W00-0730 W00-1303
(Gale and Church, 1991) has used the 2 statistics as the correspondence level of the word pairs and has showed that it was more e ective than the mutual information.
H91-1026
(Melamed, 1997) has proposed the Competitive Linking Algorithm for linking the word pairs and a method which calculates the optimized correspondence level of the word pairs by hill climbing.
P97-1063
Like our method, researches which are not based on the assumption of the sentence alignments for parallel corpora have been done (Kaji and Aizono, 1996; Tanaka and Iwasaki, 1996; Fung, 1997).
C96-1006 W97-0119
Works With di erence from our method, there have been researches which are based on the assumption of the sentence alignments for parallel corpora (Gale and Church, 1991; Kitamura and Matsumoto, 1996; Melamed, 1997).
H91-1026 P97-1063 W96-0107
(Kitamura and Matsumoto, 1996) has used the Dice coe cient (Kay and R¨oschesen, 1993) which was weighted by the logarithm of the frequency of the word pair as the Table 2: Examples of translation pairs extracted by our method Japanese English a0a2a1a2a3a2a4a2a5a2a6a2a7a9a8a10a5a2a6a2a11 chairman of a special program committee a12a14a13a16a15a2a17a14a18a2a19a10a20a22a21 o cially retired as a23 a17 a8a2a24a10a1a2a25a14a8a9a26a16a27a2a28a14a29a2a30 a21a16a31a14a32a2a33a22a34 would like to say an o cial farewell 30a35 a18a10a36a14a33a2a37a39a38 a8a10a40a2a41 my thirty years of experience a42a10a43a14a44 a8a10a45a14a29a10a46a9a47 a37 sharpen up on my golf Table 3: Precision rate and recall rate when each kind of features is removed Feature Num.
J93-1006 W96-0107
(Kaji and Aizono, 1996) has proposed the correspondence level calculated by the size of intersection between co-occurrence sets with the word included in an existing translation dictionary.
C96-1006
