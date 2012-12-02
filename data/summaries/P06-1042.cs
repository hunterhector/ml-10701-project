. . ), • the SXPipe pre-syntactic processing chain (Sagot and Boullier, 2005), that converts a raw text in a sequence of DAGs of forms that are present in the Lefff ; SXPipe contains, among other modules, a sentence-level segmenter, a tokenization and spelling-error correction module, named-entities recognizers, and a non-deterministic multi-word identifier.
W05-1501
5Such an information, which is extremely valuable for the developers of the resources, can not be obtained by global (form-level and not occurrence-level) approaches such as the err(f)-based approach of (van Noord, 2004).
P04-1057
Using directly van Noord’s measure selects as most suspicious words very rare words, which shows the importance of a good balance between suspicion rate and frequency (as noted by (van Noord, 2004) in the discussion of his results).
P04-1057
7However, the algorithms shares many common points with iterative algorithm that are known to converge and that have been proposed to find maximum entropy probability distributions under a set of constraints (Berger et al., 1996).
J96-1002
To achieve this, the use of these resources at a largescale in parsers is a very promising approach (van Noord, 2004), and in particular the analysis of situations that lead to a parsing failure: one can learn from one’s own mistakes.
P04-1057
This is what van Noord (2004) does, without trying to identify a suspicious form in any sentence whose parsing failed, and thus without taking into account the fact that there is (at least) one cause of error in each unparsable sentence.1 On the contrary, we will look, in each sentence on which parsing failed, for the form that has the highest probability of being the cause of this failure: it is the main suspect of the sentence.
P04-1057
2.1 General idea The idea we implemented is inspired from (van Noord, 2004).
P04-1057
The SXLFG parser (Boullier and Sagot, 2005b; Boullier and Sagot, 2005a) is an efficient and robust LFG parser.
W05-1501
results with results of other algorithms In order to validate our approach, we compared our results with results given by two other relevant algorithms: • van Noord’s (van Noord, 2004) (form-level and non-iterative) evaluation of err(f) (the rate of non-parsable sentences among sentences containing the form f), • a standard (occurrence-level and iterative) maximum entropy evaluation of each form’s contribution to the success or the failure of a sentence (we used the MEGAM package (Daumé III, 2004)).
P04-1057
