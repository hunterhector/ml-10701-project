This is somewhat similar to the chunk-based system described by Pradhan et al.(2005a), which uses a segmentation strategy based on IOB2 bracketing.
P05-1072
To construct the features used by the classifiers, we used the following tools: • An HMM-based POS tagger, • A rule-based chunker, • A rule-based time expression detector, • Two clause identifiers, of which one is rulebased and one is statistical, • The MALTPARSER dependency parser (Nivre et al., 2004), trained on a 100,000word Swedish treebank.
W04-2407
Features Most of the features that we use have been used by almost every system since the first well-known description (Gildea and Jurafsky, 2002).
J02-3001
Context Features Similarly to the chunk-based PropBank argument bracketer described by Pradhan et al.(2005a), the start-end methods use the head word, head POS, and chunk type of chunks in a window of size 2 on both sides of the current chunk to classify it as being the start or end of an FE.
P05-1072
Recent work in semantic role labeling, see for example Pradhan et al.(2005b), has focused on combining the results of SRL systems based on different types of syntax.
P05-1072
1.1 FrameNet: an Introduction FrameNet (Baker et al., 1998) is a lexical database that describes English words using Frame Semantics (Fillmore, 1976).
P98-1013
The result is slightly lower than the best systems at Senseval3 (Litkowski, 2004), possibly because we used a larger set of frames, and we did not assume that the frame was known a priori.
W04-0803
A rather different method to construct bilingual semantic role annotation is the approach taken by BiFrameNet (Fung and Chen, 2004).
C04-1134
For instance, the current FrameNet corpus (Baker et al., 1998) consists of 130,000 manually annotated sentences.
P98-1013
We projected the bracketing of the target words and the frame elements onto the Swedish side of the corpus by using the Giza++ word aligner (Och and Ney, 2003).
J03-1002
Johansson and Nugues (2005) applied the wordbased methods of Yarowsky et al.(2001) and obtained promising results.
H01-1035
Although the strict measures are more interesting, we include these figures for comparison with the systems participating in the Senseval-3 Restricted task (Litkowski, 2004).
W04-0803
Building SRL systems for English has been studied widely (Gildea and Jurafsky, 2002; Litkowski, 2004), inter alia.
J02-3001 W04-0803
