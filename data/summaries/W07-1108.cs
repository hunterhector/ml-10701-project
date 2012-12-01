Proposals for computing acceptability (or preference) include raw frequency counts ((Evans and Zhai, 1996) and (Lapata and Keller, 2004)), Latent Semantic Indexing ((Buckeridge and Sutcliffe, 2002)) and statistical measures of association ((Lapata et al., 1999) and (Nakov and Hearst, 2005)).
N04-1016
2http://www.gate.ac.uk 3http://nlp.stanford.edu/software/tagger.shtml 166 We adopted a similar strategy with the domain independent full parsing system RASP (Briscoe et al., 2006).
P06-4020
In brief, the abstracts of 16,609 articles curated by FlyBase were retrieved and tokenized by RASP (Briscoe et al., 2006).
P06-4020
Briscoe. 2006.
P06-4020
The system tokenizes, tags, lemmatizes and parses input sentences using the recent (second) release of the RASP (Robust Accurate Statistical Parsing) system (Briscoe et al., 2006) which parses arbitrary English text with state-of-the-art levels of accuracy.
P06-4020
Its main components are the Conditional Random Fields toolkit MALLET2 (McCallum, 2002) and the RASP syntactic parsing toolkit3 (Briscoe et al., 2006), which are both publicly available.
P06-4020
(Charniak, 2000; Briscoe et al., 2006), have wide coverage and yield grammatical representations capable of supporting various applications (e.g.
P06-4020
Lapata and Keller?s (2004) unsupervised approach is a notable exception.
N04-1016
(Lapata and Keller, 2004) use the document counts returned by WWW search engines.
N04-1016
To model aspects of co-occurrence association that might be obscured by raw frequency, the log-likelihood ratio G2 (Dunning, 1993) was also used to transform the feature space.
J93-1003
Dunning. 1993.
J93-1003
(Lapata and Keller, 2004) results also support this assertion.
N04-1016
It was later applied by (Dunning, 1993) as a way to determine if a sequence of N words (Ngram) came from an independently distributed sample.
J93-1003
Both corpora were lemmatised, tagged and parsed with RASP (Briscoe et al., 2006).
P06-4020
So far, various supervised learning approaches have been explored in this field (Culotta and Sorensen, 2004; Zelenko et al., 2003).
P04-1054
For example, Culotta and Sorensen (2004) combine word similarity and relation similarity for relation extraction; Gliozzo et al.(2005) combine word similarity and token similarity for word sense disambiguation.
P04-1054 P05-1050
Lapata and Keller (2004) use Web counts for phrases Noun P Noun where P belongs to a predefined set of prepositions.
N04-1016
Dependency trees have been used in a variety of NLP applications, such as relation extraction (Culotta and Sorensen, 2004) and machine translation (Ding and Palmer, 2005).
P04-1054
Wikipedia has shown promise as a resource for measuring word similarity (Strube and Ponzetto, 2006) and relation similarity (Suchanek et al.(2006)). References Ted Briscoe, John Carroll, and Rebecca Watson.
W06-0503
In order to ensure accuracy of the paraphrases, we use statistics gathered from the Web, using a variation of the approaches presented in Lapata and Keller (2004) and Nakov and Hearst (2005).
N04-1016
We have also described the first application of string kernels to the compound task, though gap-weighted kernels have beenusedsuccessfullyforrelatedtaskssuchasword sense disambiguation (Gliozzo et al., 2005) and relation extraction (Bunescu and Mooney, 2005).
P05-1050
