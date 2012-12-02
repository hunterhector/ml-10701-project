This WFST is then summed with the WFST implementing the dictionary and morphological rules, and the transitive closure of the resulting transducer is computed; see Pereira, Riley, and Sproat (1994) for an explanation of the notion of summing WFSTs) 2 Conceptual Improvements over Chang et al.'s Model.
H94-1050
Thus we have some confidence that our own performance is at least as good as that of Chang et al.(1992). In a more recent study than Chang et al., Wang, Li, and Chang (1992) propose a surname-driven, non-stochastic, rule-based system for identifying personal names.
C92-4199
Furthermore, even the size of the dictionary per se is less important than the appropriateness of the lexicon to a particular test corpus: as Fung and Wu (1994) have shown, one can obtain substantially better segmentation by tailoring the lexicon to the corpus to be segmented.
A94-1030
For example Chen and Liu (1992) report precision and recall rates of over 99%, but this counts only the words that occur in the test corpus that also occur in their dictionary.
C92-1019
Others depend upon various lexical heuristics: for example Chen and Liu (1992) attempt to balance the length of words in a three-word window, favoring segmentations that give approximately equal length for each word.
C92-1019
All notions of word, with the exception of the orthographic word, are as relevant in Chinese as they are in English, and just as is the case in other languages, a word in Chinese may correspond to one or more symbols in the orthog1 For a related approach to the problem of word-segmention in Japanese, see Nagata (1994), inter alia.
C94-1032
However, this result is consistent with the results of experiments discussed in Wu and Fung (1994).
A94-1030
(See also Wu and Fung \[1994\]).
A94-1030
Furthermore, by inverting the transducer so that it maps from phonemic transcriptions to hanzi sequences, one can apply the segmenter to other problems, such as speech recognition (Pereira, Riley, and Sproat 1994).
H94-1050
More formally, we start by representing the dictionary D as a Weighted Finite State Transducer (WFST) (Pereira, Riley, and Sproat 1994).
H94-1050
The major problem for our segmenter, as for all segmenters, remains the problem of unknown words (see Fung and Wu \[1994\]).
A94-1030
It has been shown for English (Wang and Hirschberg 1992; Hirschberg 1993; Sproat 1994, inter alia) that grammatical part of speech provides useful information for these tasks.
C92-4199
381 Computational Linguistics Volume 22, Number 3 Church and Hanks \[1989\]), and we have used lists of character pairs ranked by mutual information to expand our own dictionary.
P89-1010
However, until such standards are universally adopted in evaluating Chinese segmenters, claims about performance in terms of simple measures like percent correct should be taken with a grain of salt; see, again, Wu and Fung (1994) for further arguments supporting this conclusion.
A94-1030
396 Sproat, Shih, Gale and Chang Word-Segmentation for Chinese Table 4 Differences in performance between our system and Wang, Li, and Chang (1992).
C92-4199
387 Computational Linguistics Volume 22, Number 3 ogy (Koskenniemi 1983; Antworth 1990; Tzoukermann and Liberman 1990; Karttunen, Kaplan, and Zaenen 1992; Sproat 1992); we represent the fact that ~ attaches to nouns by allowing c-transitions from the final states of all noun entries, to the initial state of the sub-WFST representing iTS.
C90-3049 C92-1025
Let us assume the existence of a function Id, which takes as input an FSA A, and produces as output a transducer that maps all and only the strings of symbols accepted by A to themselves (Kaplan and Kay 1994).
J94-3001
Methods for expanding the dictionary include, of course, morphological rules, rules for segmenting personal names, as well as numeral sequences, expressions for dates, and so forth (Chen and Liu 1992; Wang, Li, and Chang 1992; Chang and Chen 1993; Nie, Jin, and Hannan 1994).
C92-1019 C92-4199
379 Computational Linguistics Volume 22, Number 3 A minimal requirement for building a Chinese word segmenter is obviously a dictionary; furthermore, as has been argued persuasively by Fung and Wu (1994), one will perform much better at segmenting text by using a dictionary constructed with text of the same genre as the text to be segmented.
A94-1030
