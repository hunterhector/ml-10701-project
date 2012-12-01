To build such systems, we train a family of Naive Bayes classifiers on a large set of examples that are generated automatically from two corpora: a corpus of 41,147,805 English sentences that have no annotations, and BLIPP, a corpus of 1,796,386 automatically parsed English sentences (Charniak, 2000), which is available from the Linguistic Data Consortium (www.ldc.upenn.edu).
A00-2018
To each text span in the BLIPP corpus corresponds a parse tree (Charniak, 2000).
A00-2018
This corresponds to an increase in accuracy from a101a69a103a63a93a69a95a69a99a43a101a104a97 a94a64a91a63a98 to a23a62a101a69a95a85a65a86a92a10a99a63a94a63a30a7a93a69a95a69a99a43a101a105a97a107a106a63a101a64a98 . 5 Discussion In a seminal paper, Banko and Brill (2001) have recently shown that massive amounts of data can be used to significantly increase the performance of confusion set disambiguators.
P01-1005
For example, the RST-annotated corpus of Carlson et al.(2001) contains 238 CONTRAST relations that hold between two adjacent elementary discourse units.
W01-1605
The second, called BLIPP, is a corpus of only 1,796,386 sentences that were parsed automatically by Charniak (2000).
A00-2018
(In the RST corpus built by Carlson et al.(2001), 89 out of the 106 occurrences of “but” that occur at the beginning of a sentence signal a CONTRAST relation that holds between the sentence that contains the word “but” and the sentence that precedes it).
W01-1605
However, empirical work of Marcu (2000) and Carlson et al.(2001) suggests that the majority of occurrences of “but”, for example, do signal CONTRAST relations.
W01-1605
If no cue phrases are used to signal the relation between two elementary discourse units, an automatic discourse labeler can at best guess that an ELABORATION relation holds between the units, because ELABORATION relations are the most frequently used relations (Carlson et al., 2001).
W01-1605
We employed our classifiers on the manually labeled examples extracted from Carlson et al.’s corpus (2001).
W01-1605
In the corpus of Rhetorical Structure trees (www.isi.edu/a2 marcu/discourse/) built by Carlson et al.(2001), for example, we have observed that only 61 of 238 CONTRAST relations and 79 out of 307 EXPLANATION-EVIDENCE relations that hold between two adjacent clauses were marked by a cue phrase.
W01-1605
To test this, we used the corpus of discourse trees built in the style of RST by Carlson et al.(2001). We automatically extracted from this manually annotated corpus all CONTRAST, CAUSE-EXPLANATION-EVIDENCE, CONDITION and ELABORATION relations that hold between two adjacent elementary discourse units.
W01-1605
