More details about the baseline system can be found in (Mauser et al., 2006) 3.2 Source Sentence Reordering Framework Encouraged by the work of (Xia and McCord, 2004) and (Crego and Mari˜no, 2006), we also reorder the source language side.
C04-1073
Here, we train word alignments in both directions with GIZA++ (Och and Ney, 2003).
J03-1002 P03-1021
Och. 2003.
J03-1002 P03-1021
(Xia and McCord, 2004) propose an approach for translation from French-to-English.
C04-1073
(Koehn and Knight, 2003) apply a reranking approach to the sub-task of noun-phrase translation.
E03-1076
of Computing Tech., Chinese Lexical Analysis System (ICTCLAS)” (Zhang et al., 2003), which does the two tasks in one pass.
W03-1709
Decoding lattices were already used in (Zens et al., 2002; Kanthak et al., 2005).
W05-0831
(Wu, 1997; Yamada and Knight, 2001; Gildea, 2003; Melamed, 2004; Graehl and Knight, 2004; Galley et al., 2006).
J97-3002 N04-1014 P01-1067 P03-1011 P04-1083 P06-1121
The Chinese text processing uses word segmentation with the ICTCLAS segmenter (Zhang et al., 2003).
W03-1709
Alternatively, one can train them with respect to the final translation quality measured by an error criterion (Och, 2003).
J03-1002 P03-1021
(Collins et al., 2005) describe a method for reordering German for German-toEnglish translation, where six transformations are applied to the surface string of the parsed source sentence.
P05-1066
(Och et al., 2004) and (Shen et al., 2004) describe the use of syntactic features in reranking the output of a full translation system, but the syntactic features give very small gains.
N04-1021 N04-1023
Using a log-linear model 2 (Och and Ney, 2002), we obtain: Pr(eI1|fJ1 ) = exp parenleftBigsummationtextM m=1 λmhm(e I1,fJ1 ) parenrightBig summationtext I′,e′I′1 exp parenleftBigsummationtextM m=1 λmhm(e′ I′ 1,fJ1 ) parenrightBig (3) The denominator represents a normalization factor that depends only on the source sentence fJ1 . Therefore, we can omit it during the search process.
P02-1038
Among all possible target language sentences, we will choose the sentence with the highest probability: ˆeˆI1 = argmax I,eI1 braceleftbigPr(eI 1|f J 1 ) bracerightbig (1) = argmax I,eI1 braceleftbigPr(eI 1) · Pr(f J 1 |e I 1) bracerightbig (2) This decomposition into two knowledge sources is known as the source-channel approach to statistical machine translation (Brown et al., 1990).
J90-2002
Results For the translation experiments, we report the two accuracy measures BLEU (Papineni et al., 2002) and NIST (Doddington, 2002) as well as the two error rates word error rate (WER) and positionindependent word error rate (PER).
P02-1040
Many reordering constraints have been used for word reorderings, such as ITG constraints (Wu, 1996), IBM constraints (Berger et al., 1996) and local constraints (Kanthak et al., 2005).
J96-1002 P96-1021 W05-0831
A similar conclusion is also presented in (Xia and McCord, 2004).
C04-1073
Rules There has been much work on learning and applying reordering rules on source language, such as (Nießen and Ney, 2001; Xia and McCord, 2004; Collins et al., 2005; Chen et al., 2006; Crego and Mari˜no, 2006; Popovi´c and Ney, 2006).
C04-1073 P05-1066
