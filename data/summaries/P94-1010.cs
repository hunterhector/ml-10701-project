ACKNOWLEDGEMENTS We thank United Informatics for providing us with our corpus of Chinese text, and BDC for the 'Behav5We were recently pointed to (Wang et al., 1992), which we had unfortunately missed in our previous literature search.
C92-4199
DICTIONARY REPRESENTATION The lexicon of basic words and stems is represented as a weightedfinite-state tranducer (WFST) (Pereira et al., 1994).
H94-1050
Precision and recall rates of over 99% are reported, but note that this covers only words that are in the dictionary: "the... statistics do not count the mistakes \[that occur\] due to the existence of derived words or proper names" (Chen and Liu, 1992, page 105).
C92-1019
The morphological analysis itself can be handled using well-known techniques from finite-state morphology (Koskenniemi, 1983; Antworth, 1990; Tzoukermann and Liberman, 1990; Karttunen et al., 1992; Sproat, 1992); so, we represent the fact that ~ attaches to nouns by allowing c-transitions from the final states of all noun entries, to the initial state of the sub-WFST representing ~I.
C90-3049 C92-1025
Roughly, previous work can be classified into purely statistical approaches (Sproat and Shih, 1990), statistical approaches which incorporate lexical knowledge (Fan and Tsai, 1988; Lin et al., 1993), and approaches that include lexical knowledge combined with heuristics (Chen and Liu, 1992).
C92-1019
