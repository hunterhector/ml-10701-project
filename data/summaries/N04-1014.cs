In this section, we implement the translation model of (Yamada and Knight, 2001).
P01-1067
First, it clarifies the model, in the same way that (Knight and Al-Onaizan, 1998; Kumar and Byrne, 2003) elucidate other machine translation models in easily-grasped FST terms.
N03-1019
What is sometimes called a forest in natural language generation (Langkilde, 2000; Nederhof and Satta, 2002) is a finite wRTG without loops, i.e.,∀n∈N(n,())⇒∗G (t,h) =⇒ pathst({n}) = ∅.
P02-1015
However, for English leaf nodes, we instead transition to a different state t, so as to prohibit any subsequent Japanese function word insertion: r NN(x0:car) → t x0 r CC(x0:and) → t x0 State t means “translate this word,” and we have a production for every pair of co-occurring English and Japanese words: t car → kuruma t car → wa t car → *e* This follows (Yamada and Knight, 2001) in also allowing English words to disappear, or translate to epsilon.
P01-1067
Tree-to-string transducers have also been applied to machine translation (Yamada and Knight, 2001; Eisner, 2003).
P01-1067 P03-2041
summarization (Knight and Marcu, 2002), paraphrasing (Pang, Knight, and Marcu, 2003), natural language generation (Langkilde and Knight, 1998; Bangalore and Rambow, 2000; Corston-Oliver et al., 2002), and language modeling (Baker, 1979; Lari and Young, 1990; Collins, 1997; Chelba and Jelinek, 2000; Charniak, 2001; Klein and Manning, 2003).
C00-1007 N03-1024 P01-1017 P03-1054 P97-1003
Recently, specific probabilistic tree-based models have been proposed not only for machine translation (Wu, 1997; Alshawi, Bangalore, and Douglas, 2000; Yamada and Knight, 2001; Gildea, 2003; Eisner, 2003), but also for This work was supported by DARPA contract F49620-001-0337 and ARDA contract MDA904-02-C-0450.
C00-1007 J00-1004 J97-3002 P01-1067 P03-1011 P03-2041
(Eisner, 2003) discusses training for Synchronous TSG.
P03-2041
