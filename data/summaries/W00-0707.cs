Foster. 2000.
P00-1006
This is very important for applications such as TransType (Foster et al., 1997; Langlais et al., 2000), where the task is to make real-time predictions of the text a human translator will type next, based on the source text under translation and some prefix of the target text that has already been typed.
A00-1019 P00-1006
The IBM models tested here incorporate a reduced set of 1M word-pair parameters, selected using the method described in (Foster, 2000), which gives slightly better test-corpus performance than the unrestricted set of all 35M word pairs which cooccur within aligned sentence pairs in the training corpus.
P00-1006
In previous work (Foster, 2000), I described a Maximum Entropy/Minimum Divergence (MEMD) model (Berger et al., 1996) for p(w\[hi, s) which incorporates a trigram language model and a translation component which is an analog of the well-known IBM translation model 1 (Brown et al., 1993).
J93-2003 J96-1002 P00-1006
For all MEMD models, I used 20,000 word-pair features selected using the method described in (Foster, 2000); this is suboptimal but gives reasonably good performance and facilitates experimentation.
P00-1006
However, this appears to be a weak technique (Langlais and Foster, 2000), even when A is allowed to depend on various features of the context (hi, s).
A00-1019 P00-1006
Complex and expensive search strategies are required to find the best target text in this approach (Garcfa-Varea et al., 1998; Niessen et al., 1998; Ochet al., 1999; Wang and Waibel, 1998).
W99-0604
In (Foster, 2000) I describe an 38 effective technique for selecting MEMD wordpair features.
P00-1006
Maximum likelihood estimates for these parameters can be obtained with the EM algorithm over a bilingual training corpus, as described in (Brown et al., 1993).
J93-2003
For a given choice of q and f, the IIS algorithm (Berger et al., 1996) can be used to find maximum likelihood values for the parameters ~.
J96-1002
