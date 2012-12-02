A brief summary of the micro-averaged F-score3 results is given in Table 2 (Detailed results in Hachey and Grover, 2004).
W04-1007
The approaches fall into three basic paradigms based on the methods they use to match abstract content to sentences from the source document: longest comAuthors Paradigm Level Teufel and Moens (1997) Longest common subsequence matching Sentence Mani and Bloedorn (1998) IR (a0 overlapping wordsa0a2a1 cosine-based similarity metric) Sentence Banko et al.(1999) IR (a0 overlapping wordsa0 w/ extra weight for proper nouns) Sentence Marcu (1999) IR (cosine-based similarity metric) Clause Jing and McKeown (1999) HMM (prefers ordered, contiguous words, sentences) Word Table 4: Methods for automatic alignment of abstracts with their source documents.
W97-0710
This subset of the corpus is similar in size to the corpus reported in (Teufel and Moens, 2002): the T&M corpus consists of 80 conference articles while ours consists of 40 HOLJ documents.
J02-4002
Ultimately, human supervision may be required as in Teufel and Moens (2002), however we can make some observations about the automatic annotation methods above.
J02-4002
The first step in the linguistic analysis module lemmatises the inflected words using Minnen et al.’s (2000) morpha lemmatiser.
W00-1427
Our approach to summarisation is based on that of Teufel and Moens (1999a, 2002, henceforth T&M).
J02-4002
The first approach (Teufel and Moens, 1997) uses a simple surface similarity measure (longest common subsequence of non-stop-list words) for matching abstract sentences with sentences from the source document.
W97-0710
We use different strategies for the identification of the two classes of entities: for the domain-specific ones we use hand-crafted LT TTT rules, while for the nondomain-specific ones we use the C&C named entity tagger (Curran and Clark, 2003) trained on the MUC-7 data set.
W03-0424
Teufel and Moens (2002) discuss the difference between abstracts created by document authors and those created by professional abstractors noting that the former tend to be less systematic and more “deep generated” while the latter are more likely to be created by sentence extraction.
J02-4002
The other main LT TTT program is ltpos, a statistical combined part-of-speech (POS) tagger and sentence boundary disambiguation module (Mikheev, 1997).
J97-3003
