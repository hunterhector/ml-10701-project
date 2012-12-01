This direction ever evolves from simple Damerau-Levenshtein distance (Damerau, 1964; Levenshtein, 1966) to probabilistic models that estimate string edit probabilities from corpus (Church and Gale, 1991; Mayes et al, 1991; Ristad and Yianilos, 1997; Brill and Moore, 2000; and Ahmad and Kondrak, 2005).
H05-1120 P00-1037
Toutanova and Moore (2002) further explored this via explicit modeling of phonetic information of English words.
P02-1019
Cucerzan and Brill (2004) discussed in detail specialties and difficulties of a query spell checker, and illustrated why the existing methods could not work for query spelling correction.
W04-3238
This is because query logs are not only an up-to-date term base, but also a comprehensive spelling error repository (Cucerzan and Brill, 2004; Ahmad and Kondrak, 2005).
H05-1120 W04-3238
Brill and Moore (2000) presented an improved error model over the one proposed by Kernigham et al.(1990) by allowing generic string-to-string edit operations, which helps with modeling major cognitive errors such as the confusion between le and al.
P00-1037
The work of Ahmad and Kondrak (2005) tried to employ an unsupervised approach to error model estimation.
H05-1120
Work The method for web query spelling correction proposed by Cucerzan and Brill (2004) is essentially based on a source channel model, but it requires iterative running to derive suggestions for very-difficult-to-correct spelling errors.
W04-3238
The maximum entropy model (Berger et al., 1996) provides us with a well-founded framework for this purpose, which has been extensively used in natural lan guage processing tasks ranging from part-ofspeech tagging to machine translation.
J96-1002
For the string edit-based error model probability )|( cqPed, we used a heuristic score computed as the inverse of weighted edit distance, which is similar to the one used by Cucerzan and Brill (2004).
W04-3238
Investigations into query log data reveal that more than 10% of queries sent to search engines contain misspelled terms (Cucerzan and Brill, 2004).
W04-3238
Channel Model Source channel model has been widely used for spelling correction (Kernigham et al., 1990; Mayes, Damerau et al., 1991; Brill and More, 2000; Ahmad and Kondrak, 2005).
H05-1120 P00-1037
Essentially there are different ways to estimate distributional similarity between two words (Dagan et al., 1997), and the one we propose to use is confusion probability (Essen and Steinbiss, 1992).
P97-1008
Distributional similarity between words has been investigated and successfully applied in many natural language tasks such as automatic semantic knowledge acquisition (Dekang Lin, 1998) and language model smoothing (Essen and Steinbiss, 1992; Dagan et al., 1997).
P97-1008 P98-2127
This is similar to what Och and Ney (2002) used for their maximum entropy-based statistical machine translation training.
P02-1038
An investigation on distributional similarity functions can be found in (Lillian Lee, 1999).
P99-1004
