Pang et al.(2002) and Turney (2002) classified sentiment polarity of reviews at the document level.
P02-1053 W02-1011
Wiebe et al.(1999) classified sentence level subjectivity using syntactic classes such as adjectives, pronouns and modal verbs as features.
P99-1032
Riloff and Wiebe (2003) extracted subjective expressions from sentences using a bootstrapping pattern learning process.
W03-1014
Maximum Entropy models implement the intuition that the best model is the one that is consistent with the set of constraints imposed by the evidence but otherwise is as uniform as possible (Berger et al.1996). There are two ways to model the problem with ME: classification and ranking.
J96-1002
Another related work is (Choi et al.2005) who use the MPQA corpus 2 to learn patterns of opinion sources using a graphical model and extraction pattern learning.
H05-1045
For example, the word “central” that Hatzivassiloglou and McKeown (1997) included as a positive adjective is not classified as positive in our system.
P97-1023
Our earlier experiments showed poor performance with classification modeling, an experience also reported for Question Answering (Ravichandran et al.2003). We modeled the problem to choose the most probable candidate that maximizes a given conditional probability distribution, given a set of holder candidates h 1 h 2 ...h N and opinion expression e.
W03-1209
In previous work, Choi et al.(2005) identify opinion holders (sources) using Conditional Random Fields (CRF) and extraction patterns.
H05-1045
Yu and Hatzivassiloglou (2003) identified the polarity of opinion sentences using semantically oriented words.
W03-1017
Since our opinionbearing words are in English and our target system is in German, we also applied a statistical word alignment technique, GIZA++ 6 (Och and Ney 2000).
P00-1056
