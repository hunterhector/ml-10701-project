Shieber (1988) further noted that not only a single grammar can be used for parsing and generation, but the same language-processing architecture can be used for both tasks.
C88-2128
(Details can be found in Wong and Mooney (2006).) The rules extracted from Figure 3 would be almost thesameasthoseusedinFigure2,excepttheonefor bowner: CONDITION → 〈TEAM 1 player UNUM 2 has (1) ball, (bowner TEAM 1 {UNUM 2 })〉.
N06-1056
In this paper, we show how to “invert” a recent SMT-based semantic parser, WASP (Wong and Mooney, 2006), in order to produce a more effective generation system.
N06-1056
Both metrics have recently been used to evaluate generators (Langkilde-Geary, 2002; Nakanishi et al., 2005; Belz and Reiter, 2006).
E06-1040 W05-1510
Since an SCFG is fully symmetric with respect to both generated strings, the same chart used for parsing can be easily adapted for efficient generation (Shieber, 1988; Kay, 1996).
C88-2128 P96-1027
Jacobs. 1985.
J85-4002
3.2 WASP: The Semantic Parsing Algorithm Before showing how generation can be performed by inverting a semantic parser, we present a brief overview of WASP (Wong and Mooney, 2006), the SMT-based semantic parser on which this work is based.
N06-1056
It is similar to the syntax-based SMT system of Chiang (2005), which uses both SCFG and PHARAOH’s probabilistic model.
P05-1033
Note that the order in which predicates appear need not be the same as the word order of the target NL, and therefore, the content planner need not know about the target NL grammar (Shieber, 1993).
J93-1008
Word alignment models have been widely used for lexical acquisition in SMT (Brown et al., 1993; Koehn et al., 2003).
J93-2003 N03-1017
Our BLEU scores are not as high as those reported in Langkilde-Geary (2002) and Nakanishi et al.(2005), which are around 0.7–0.9.
W05-1510
The rule weight, w(X → 〈α,β〉), is in turn defined as: P(β|α)λ1P(α|β)λ2Pw(β|α)λ3Pw(α|β)λ4 exp(−|α|)λ5 where P(β|α) and P(α|β) are the relative frequencies of β and α, and Pw(β|α) and Pw(α|β) are 176 the lexical weights (Koehn et al., 2003).
N03-1017
Compared to earlier word-based methods such as IBM Models (Brown et al., 1993), phrasebased methods such as PHARAOH are much more effective in producing idiomatic translations, and are currently the best performing methods in SMT (Koehn and Monz, 2006).
J93-2003 W06-3114
Kay (1996) identified parsing charts as such an architecture, which led to the development of various chart generation algorithms: Carroll et al.(1999) for HPSG, Bangalore et al.(2000) for LTAG, Moore (2002) for unification grammars, 178 White and Baldridge (2003) for CCG.
P96-1027 W00-1401
It has been used in syntax-based SMT to model the translation of one NL to another (Chiang, 2005).
P05-1033
One of the earliest espousals of the notion of grammar reversability can be found in Kay (1975).
T75-1004
Och. 2003.
J03-1002 P03-1021
For thelanguagemodel,weuseann-grammodel,which is remarkably useful in ranking candidate generated sentences (Knight and Hatzivassiloglou, 1995; Bangalore et al., 2000; Langkilde-Geary, 2002).
P95-1034 W00-1401
In addition to exploiting the formal MRL grammar, our approach also allows the same learned grammar to be used for both parsing and generation, an elegant property that has been widely advocated (Kay, 1975; Jacobs, 1985; Shieber, 1988).
C88-2128 J85-4002 T75-1004
Figure 4: Sample partial system output in the ROBOCUP domain ROBOCUP GEOQUERY BLEU NIST BLEU NIST PHARAOH 0.3247 5.0263 0.2070 3.1478 WASP−1 0.4357 5.4486 0.4582 5.9900 PHARAOH++ 0.4336 5.9185 0.5354 6.3637 WASP−1++ 0.6022 6.8976 0.5370 6.4808 Table 1: Results of automatic evaluation; bold type indicates the best performing system (or systems) for a given domain-metric pair (p < 0.05) 5.1 Automatic Evaluation Weperformed4runsof10-foldcrossvalidation,and measured the performance of the learned generators using the BLEU score (Papineni et al., 2002) and the NIST score (Doddington, 2002).
P02-1040
Shieber. 1993.
J93-1008
In WASP, GIZA++ (Och and Ney, 2003) is used to obtain the best alignments from the training examples.
J03-1002 P03-1021
S.M.Shieber. 1988.
C88-2128
In this paper we present results on using a recent phrase-based SMT system, PHARAOH (Koehn et al., 2003), for NLG.1 Although moderately effec1We also tried IBM Model 4/REWRITE (Germann, 2003), a word-based SMT system, but it gave much worse results.
N03-1010 N03-1017
While it is found that BLEU and NIST correlatequitewellwithhumanjudgments in evaluating NLG systems (Belz and Reiter, 2006), it is best to support these figures with human evaluation, which we did on a small scale.
E06-1040
The model parameters are trained using minimum error-rate training (Och, 2003).
J03-1002 P03-1021
Like WASP−1, the phrase extraction algorithm of PHARAOH is based on the output of a word alignment model such as GIZA++ (Koehn et al., 2003), which performs poorly when applied directly to MRLs (Section 3.2).
N03-1017
More recently, statistical chart generators have emerged, including White (2004) for CCG, Carroll and Oepen (2005) and Nakanishi et al.(2005) for HPSG.
W05-1510
This is in contrast to existing work that focuses on the use of NLG in interlingual MT (Whitelock, 1992), in which the roles of NLG and MT are switched.
C92-2117
They were presented with the following definition, adapted from Koehn and Monz (2006): Score Fluency Adequacy 5 Flawless English All meaning 4 Good English Most meaning 3 Non-native English Some meaning PHARAOH++ WASP−1++ BLEU NIST BLEU NIST English 0.5344 5.3289 0.6035 5.7133 Spanish 0.6042 5.6321 0.6175 5.7293 Japanese 0.6171 4.5357 0.6585 4.6648 Turkish 0.4562 4.2220 0.4824 4.3283 Table 3: Results of automatic evaluation on the multilingual GEOQUERY data set Score Fluency Adequacy 2 Disfluent English Little meaning 1 Incomprehensible No meaning For each generated sentence, we computed the average of the 4 human judges’ scores.
W06-3114
Following the phrase extraction phase in PHARAOH, we eliminate word gaps by incorporating unaligned words as part of the extracted NL phrases (Koehn et al., 2003).
N03-1017
using PHARAOH PHARAOH (Koehn et al., 2003) is an SMT system that uses phrases as basic translation units.
N03-1017
