An alternative would be using a vector space model for classi cation where calltypes and utterances are represented as vectors including word a2 -grams (Chu-Carroll and Carpenter, 1999).
J99-3003
In the classi erbased approach, we used simple features such as the current word and surrounding 4 words, binary tags indicating if the word considered contains any digits or is formed from digits, and features checking capitalization (Carreras et al., 2003).
W03-0421
Insertion of further information such as supertags (Bangalore and Joshi, 1999) or word stems can also be bene cial for further processing.
J99-2004
In our framework, we employ a simple HMM-based tagger, where the most probable tag sequence, a29a30, given the words, a31, is output (Weischedel et al., 1993): a29 a30 a20a22a32a34a33a36a35a38a37a39a32a41a40 a42 a43a45a44 a30a47a46 a31a49a48a17a20a22a32a34a33a50a35a38a37a39a32a41a40 a42 a43a45a44 a31 a46a30 a48 a43a51a44 a30 a48 Since we do not have enough data which is manually tagged with part-of-speech tags for our applications, we used Penn Treebank (Marcus et al., 1994) as our training set.
J93-2006
4.1 Part-of-Speech Tagger Part-of-speech tagging has been very well studied in the literature for many languages, and the approaches vary from rule-based to HMM-based and classi er-based (Church, 1988; Brill, 1995, among others) tagging.
A88-1019 J95-4004
For semantic role labeling, we have used the exact same feature set that Hacioglu et al.(2004) have used, since their system performed the best among others in the CoNLL2004 shared task (Carreras and M arquez, 2004).
W04-2412 W04-2416
Church. 1988.
A88-1019
This step can be seen as a multi-label, multi-class call classi cation problem for customer care applications (Gorin et al., 1997; Chu-Carroll and Carpenter, 1999; Gupta et al., To appear, among others).
J99-3003
training data (van Halteren et al., 2001), we achieve a very reasonable performance, considering these errors.
J01-2002
