References T.Emerson. 2005.
I05-3017
J.K.Low et al.2005. A Maximum Entropy Approach to Chinese Word Segmentation.
I05-3025
T.Nakagawa. 2004.
C04-1067
Researchers use word-level features (J.K.Low et al.,2005) to solve this problem.
I05-3025
* )|(maxarg )...|...(maxarg 21 21 (2) Beam search (n=3) (Ratnaparkhi,1996) is applied for tag sequence searching, but we only search the valid sequences to ensure the validity of searching result.
W96-0213
A.Ratnaparkhi. 1996.
W96-0213
Dealing with word segmentation as character tagging showed good results in last SIGHAN Bakeoff (J.K.Low et al.,2005). It is good at unknown word identification, but only using character-level features sometimes makes mistakes when identifying known words (T.Nakagawa, 2004).
C04-1067 I05-3025
Named entity recognition based on charactertagging has shown better accuracy than wordbased methods (H.Jing et al.,2003). But the small window of text makes it difficult to recognize the named entities with many characters, such as organization names (H.Jing et al.,2003). Considering about this, we developed a NER system based on character-tagging, which combines word-level and character-level features together.
W03-1026
At last, all the punctuations in Penn Chinese Treebank 5.1 (N.Xue et al.,2002) and all the words in the training data of UPUC and MSRA corpuses are added into the lexicon.
C02-1145
It is also binary feature and all the punctuations in the punctuation character list come from Penn Chinese Treebank 5.1 (N.Xue et al.,2002). In addition, we define some word-level features based on a lexicon to enlarge the window size of text in the two tasks, which are: (c) Wn (n=-1,0,1) Feature Wn (n=-1,0,1) mean the lexicon words in different positions (the word containing C0 and one word to its left and right) and they are also binary features.
C02-1145
N.Xue et al.2002. Building a Large-Scale Annotated Chinese Corpus.
C02-1145
First, a lexicon from NICT (National Institute of Information and Communications Technology, Japan) is used as the basic lexicon, which is extracted from Peking University Corpus of the second SIGHAN Bakeoff (T.Emerson, 2005), Penn Chinese Treebank 4.0 (N.Xue et al.,2002), a Chinese-to-English Wordlist1 and part of NICT corpus (K.Uchimoto et al.,2004; Y.J.Zhang et al.,2005). Then, all the words containing digits and letters are removed 1 http://projects.ldc.upenn.edu/Chinese/ from this lexicon.
C02-1145 I05-3017 W04-2208
H.Jing et al.2003. HowtogetaChineseName(Entity): Segmentation and Combination Issues.
W03-1026
We select all the possible words in the lexicon that satisfy the requirements, not like only selecting the longest one in (J.K.Low et al.,2005). To create the lexicon, we use following steps.
I05-3025
K.Uchimoto et al.2004. Multilingual Aligned Parallel Treebank Corpus Reflecting Contextual Information and its Applications.
W04-2208
