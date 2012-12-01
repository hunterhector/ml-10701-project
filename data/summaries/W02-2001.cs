4 Method-2: Simple Chunk-based Extraction To overcome the shortcomings of the Brill tagger in identifying particles, we next look to full chunk 2Note, this is the same as the maximum span length of 5 used by Smadja (1993), and above the maximum attested NP length of 3 from our corpus study (see Section 2.2).
J93-1007
The F-score of 0.919 for the CoNLL2000 data is roughly the median score attained by systems performing in the original task, and slightly higher than the F-score of 0.915 reported by Veenstra and van den Bosch (2000), due to the use of word lemmata rather than surface forms, and also inverse distance weighting.
W00-0735
In the latter case, we use an unsupervised attachment disambiguation method, based on the log-likelihood ratio (\LLR", Dunning (1993)).
J93-1003
In line with our assumption of raw text to extract over, we use the Brill tagger (Brill, 1995) to automatically tag the WSJ, rather than making use of the manual POS annotation provided in the Penn Treebank.
J95-4004
parsing method In order to chunk parse the WSJ, we flrst tagged the full WSJ and Brown corpora using the Brill tagger, and then converted them into chunks based on the original Penn Treebank parse trees, with the aid of the conversion script used in preparing the CoNLL-2000 shared task data.3 We next lemmatised the data using morph (Minnen et al., 2000), and chunk parsed the WSJ with TiMBL 4.1 (Daelemans et al., 2001) using the Brown corpus as training data.
W00-1427
We ran TiMBL based on the feature set described in Veenstra and van den Bosch (2000), that is using the 5 word lemmata and POS tags to the left and 3 word lemmata and POS tags to the right of each focus word, along with the POS tag and lemma for the focus word.
W00-0735
In the chunk inventory devised for the CoNLL-2000 test chunking shared task (Tjong Kim Sang and Buchholz, 2000), a dedicated particle chunk type once again exists.
W00-0726
The primary reason for the large disparity between the Brill tagger output and original Penn Treebank annotation is that it is notoriously di–cult to difierentiate between particles, prepositions and adverbs (Toutanova and Manning, 2000).
W00-1308
One aspect of VPCs that makes them di–cult to extract (cited in, e.g., Smadja (1993)) is that the verb and particle can be non-contiguous, e.g. hand the paper in and battle right on.
J93-1007
non-contiguous collocations, including VPCs), was that of Smadja (1993).
J93-1007
Any linguistic annotation required during the extraction process, therefore, is produced through automatic means, and it is only for reasons of accessibility and comparability with other research that we choose to work over the Wall Street Journal section of the Penn Treebank (Marcus et al., 1993).
J93-2004
4Based on the results of Veenstra and van den Bosch (2000) and the observation that MVDM is temperamental over sparse data (i.e.
W00-0735
