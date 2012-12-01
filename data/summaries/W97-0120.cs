Once word segmentation is done, all established techniques can be exploited to build practically important applications such as spelling correction \[Nagata, 1996\] and text retrieval \[Nie and Brisebois, 1996\] In a sense, Japanese word segmentation is a solved problem if (and only if) we have plenty of segmented training text.
C96-2136
jp/edx/. \[Elworthy, 1994\] David Elworthy.
A94-1009
\[Sproat et al., 1996\] built a word unigram model using the Viterbi re-estimation whose initial estimates were derived from the frequencies in the corpus of the strings of each word in the lexicon.
J96-3004
Measures Word Segmentation accuracy is expressed in terms of recall and precision as is done for bracketing of partial parses \[Nagata, 1994, Sproat et al., 1996\].
C94-1032 C96-2136 J96-3004
Frequency \[Sproat et al., 1996\] also proposed another method to estimate a set of initial word frequencies without segmenting the corpus.
J96-3004
Both \[Yamamoto, 1996\] and \[Takeuchi and Matsumoto, 1995\] built a word-based language model from unsegmented text 203 using a re-estimation procedure whose initial segmentation was obtained by a rule-based word segreenter.
W96-0113
\[Chang et al., 1995\] combined a small seed segmented corpus and a large unsegmented corpus to build a word unigram model using the Viterbi re-estimation.
W95-0109
\[Luo and Roukos, 1996\] Xiaoqiang Luo and SAllm Roukos.
P96-1019
References \[Chang et al., 1995\] Jing-Shin Chang, Yi-Chung Lin, and Keh-Yih Su.
W95-0109
Although \[Kupiec, 1992\] presented a very sophisticated method of unsupervised learning, \[Elworthy, 1994\] reported that re-estimation is not always helpful.
A94-1009
\[Sproat et al., 1996\] wrote lexical rules for each productive morphological process, such as plural noun formation, Chinese personal names, and transliterations of foreign words.
J96-3004
Re-estlmation We used the Viterbi-like dyn~m~c programing procedure described in \[Nagata, 1994\] to get the most likely word segmentation.
C94-1032
The problem of the longest match string frequency method is that if a word W1 is a substring of other word W2 and if W1 always appears as a substring of W2 in the training text, just like "~ Although \[Sproat et al., 1996\] calls it '~maximum matching", we call this method "longest match" according to a review on Chinese word segmentation \[Wu and Tseng, 1993\] and the literal translation of the Japanese name of the method t'~--~.
J96-3004
\[Nagata, 1996\] Masaaki Nagata.
C96-2136
\[Nagata, 1994\] Masaaki Nagata.
C94-1032
Around 95% word segmentation accuracy is reported by using a word-based language model and the Viterbi-like dynamic programi-g procedure \[Nagata, 1994, Takeuchi and Matsumoto, 1995, Yamamoto, 1996\].
C94-1032 C96-2136 W96-0113
\[Luo and Roukos, 1996\] proposed a re-estimation procedure which alternates word segmentation and word frequency re-estimation on each half of the training text divided into halves.
P96-1019
\[Chang et al., 1995\] used a statistical method called "Two-Class Classifier", which decided whether the string is actually a word based on the features derived from character N-gram.
W95-0109
\[Sproat et al., 1996\] Richard Sproat, Chilin Shih, William Gale, and Nancy Chang.
J96-3004
We used a simple greedy algorithm described in \[Sproat et al., 1996\].
J96-3004
