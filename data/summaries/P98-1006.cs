2.1 Lexical head transducers In our training method, we follow the simple lexical head transduction model described by Alshawi (1996b) which can be regarded as a type of statistical dependency grammar trans41 duction.
P96-1023
In this paper, we show that both the network topology and parameters of a head transducer translation model (Alshawi, 1996b) can be learned fully automatically from a bilingual corpus.
P96-1023
It has already been shown (Alshawi et al., 1997) that a head transducer model with hand-coded structure can be trained to give better accuracy than a comparable transfer-based system, with smaller model size, computational requirements, and development effort.
P97-1046
We tried using the log probabilities of target subsequences given source subsequences (cf Brown et al.(1990)) as a cost function instead of ¢ but ¢ resulted in better performance of our translation models.
J90-2002
The work reported in Wu (1997), which uses an inside-outside type of training algorithm to learn statistical contextfree transduction, has a similar motivation to the current work, but the models we describe here, being fully lexical, are more suitable for direct statistical modelling.
J97-3002
In general, the likelihood of a head-dependent relation decreases as distance increases (Collins, 1996).
P96-1025
The first cost function is the ¢ correlation measure (cf the use of ¢2 in Gale and Church (1991)) computed as follows: = (bcad) x/(a + b)(c + d)(a + c)(b + d) where a = nv -n~,i~v b = nw, y c = N nv nw + nw, v d = nw nw, v N is the total number of bitexts, nv the number of bitexts in which V appears in the target, nw the number of bitexts in which W appears in the source, and nw, y the number of bitexts in which W appears in the source and V appears in the target.
H91-1026
