The readers familiar with the statistical machine translation (SMT) literature should recognize that steps 3 to 5 are nothing but a one-to-one reproduction of the generative story proposed in the SMT context by Brown et al.(see Brown et al., 1993 for a detailed mathematical description of the model and the formula for computing the probability of an alignment and target string given a source string).
J93-2003
To help our model learn that it is desirable to copy answer words into the question, we add to each corpus a list of identical dictionary word pairs w iw i . For each corpus, we use GIZA (Al-Onaizan et al., 1999), a publicly available SMT package that implements the IBM models (Brown et al., 1993), to train a QA noisy-channel model that maps flattened answer parse trees, obtained using the “cut” procedure described in Section 3.1, into questions.
J93-2003
Church. 1988.
A88-1019
Being inspired by the success of noisy-channel-based approaches in applications as diverse as speech recognition (Jelinek, 1997), part of speech tagging (Church, 1988), machine translation (Brown et al., 1993), information retrieval (Berger and Lafferty, 1999), and text summarization (Knight and Marcu, 2002), we develop a noisy channel model for QA.
A88-1019 J93-2003
1: A generative model for Question answering To simplify our work and to enable us exploit existing off-the-shelf software, in the experiments we carried out in conjunction with this paper, we assumed a flat distribution for the two steps in our 1 The distortion probabilities depicted in Figure 1 are a simplification of the distortions used in the IBM Model 4 model by Brown et al.(1993). We chose this watered down representation only for illustrative purposes.
J93-2003
