The context of a current token ti is clearly one of the most important features in predicting whether ti is a mention or not (Florian et al., 2004).
N04-1001
Segmentation Lee et al.(2003) demonstrates a technique for segmenting Arabic text and uses it as a morphological processing step in machine translation.
P03-1051
(Luo et al., 2004) for how ECM-F is computed), and ACE-Value is the official ACE evaluation metric.
P04-1018
Both tasks are performed with a statistical framework: the mention detection system is similar to the one presented in (Florian et al., 2004) and the coreference resolution system is similar to the one described in (Luo et al., 2004).
N04-1001 P04-1018
As in (Lee et al., 2003), we used unsupervised training data which is automatically segmented to discover previously unseen stems.
P03-1051
The coreference system system is similar to the Bell tree algorithm as described by (Luo et al., 2004).
P04-1018
The principle of maximum entropy states that when one searches among probability distributions that model the observed data (evidence), the preferred one is the one that maximizes the entropy (a measure of the uncertainty of the model) (Berger et al., 1996).
J96-1002
Our Arabic entity recognition system uses many language-indepedent features such as strict and partial string match, and distance features (Luo et al., 2004).
P04-1018
SEP/epsilon a/A# epsilon/# a/epsilon a/epsilon b/epsilon b/B UNK/epsilon c/C b/epsilon c/BC e/+E epsilon/+ d/epsilon d/epsilon epsilon/epsilon b/AB# b/A#B# e/+DE c/epsilon d/BCD e/+D+E Figure 1: Illustration of dictionary based segmentation finite state transducer 3.1 Bootstrapping In addition to the model based upon a dictionary of stems and words, we also experimented with models based upon character n-grams, similar to those used for Chinese segmentation (Sproat et al., 1996).
J96-3004
Both systems are built around from the maximum-entropy technique (Berger et al., 1996).
J96-1002
where mk is one mention in entity e, and the basic model building block ˆPL(L = 1je, mk, m) is an exponential or maximum entropy model (Berger et al., 1996).
J96-1002
The EDR has close ties to the named entity recognition (NER) and coreference resolution tasks, which have been the focus of several recent investigations (Bikel et al., 1997; Miller et al., 1998; Borthwick, 1999; Mikheev et al., 1999; Soon et al., 2001; Ng and Cardie, 2002; Florian et al., 2004), and have been at the center of evaluations such as: MUC-6, MUC-7, and the CoNLL’02 and CoNLL’03 shared tasks.
A97-1029 E99-1001 J01-4004 N04-1001 P02-1014
Differing from (Lee et al., 2003), we have also introduced an explicit model for un1As an example, we do not chain mentions with different gender, number, etc.
P03-1051
Stem Match Feature Features using the word context (left and right tokens) have been shown to be very helpful in coreference resolution (Luo et al., 2004).
P04-1018
