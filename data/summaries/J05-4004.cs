The most relevant work is that of Jing (2002), in which a hidden Markov alignment model is applied to the task of identifying word and phrase-level correspondences between documents and abstracts.
J02-4006
This is quite different from the various approaches to incorporating syntactic knowledge into machine translation systems, wherein strong assumptions about the possible syntactic operations are made (Yamada and Knight 2001; Eisner 2003; Gildea 2003).
P01-1067 P03-1011 P03-2041
One obvious first approach would be to run a simpler model for the first iteration (for example, Model 1 from machine translation (Brown et al.1993), which tends to be very recall oriented) and use this to see subsequent iterations of the more complex model.
J93-2003
Work on Alignments In the sentence extraction community, there exists a wide variety of techniques for (essentially) creating alignments between document sentences and abstract sentences (Kupiec, Pedersen, and Chen 1995; Teufel and Moens 1997; Marcu 1999); see also Barzilay and Elhadad (2003); Quirk, Brockett, and Dolan (2004) for work describing alignments for the monolingual paraphrasing task.
W03-1004 W04-3219 W97-0710
Guidelines Annotators were asked to perform word-to-word and phrase-to-phrase alignments between abstracts and documents, and to classify each alignment as either possible (P) or sure (S), where S ⊆ P, following the methodology used in the machine translation community (Och and Ney 2003).
J03-1002
Headline generation systems, on the other hand, typically extract individual words from a document to produce a very short headline-style summary; see Banko, Mittal, and Witbrock (2000); Berger and Mittal (2000); Schwartz, Zajic, and Dorr (2002) for representative examples.
P00-1038 P00-1041
Our system outperforms competing approaches, including the standard machine translation alignment models (Brown et al.1993; Vogel, Ney, and Tillmann 1996) and the state-of-the-art Cut and Paste summary alignment technique (Jing 2002).
C96-2141 J02-4006 J93-2003
Between these two extremes, there has been a relatively modest amount of work in sentence simplification (Chandrasekar, Doran, and Bangalore 1996; Mahesh 1997; Carroll et al.1998; Grefenstette 1998; Jing 2000; Knight and Marcu 2002) and document compression (Daum´e III and Marcu 2002; Daum´e III and Marcu 2004; Zajic, Dorr, and Schwartz 2004) in which words, phrases, and sentences are selected in an extraction process.
A00-1043 C96-2183 J02-4006
Based on these efforts, one might be initially tempted to use readily available alignment models developed in the context of machine translation, such as GIZA++ (Och and Ney 2003), to obtain wordlevel alignments in 〈document, abstract〉 corpora.
J03-1002
This could be coupled with heuristic phrasal creation as is done in machine translation (Och and Ney 2000), but by doing this, one completely loses the probabilistic interpretation that makes this model so pleasing.
P00-1056
We also tested alignments using the Cut and Paste summary decomposition method (Jing 2002), based on a non-trainable HMM.
J02-4006
We compare our model against well-known alignment models designed for machine translation as well as a state-of-the-art alignment model specifically designed for summarization (Jing 2002).
J02-4006
We compare against several competing systems, the first of which is based on the original IBM Model 4 for machine translation (Brown et al.1993) and the HMM machine translation alignment model (Vogel, Ney, and Tillmann 1996) as implemented in the GIZA++ package (Och and Ney 2003).
C96-2141 J03-1002 J93-2003
In the context of headline generation, simple statistical models are used for aligning documents and headlines (Banko, Mittal, and Witbrock 2000; Berger and Mittal 2000; Schwartz, Zajic, and Dorr 2002), based on IBM Model 1 (Brown et al.1993). These models treat documents and headlines as simple bags of words and learn probabilistic word-based mappings between the words in the documents and the words in the headlines.
J93-2003 P00-1038 P00-1041
Second, we compare against the Cut and Paste model developed in the context of “summary decomposition” by Jing (2002).
J02-4006
