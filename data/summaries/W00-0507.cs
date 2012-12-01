The potential gain from multiple-word predictions (Langlais et al., 2000) can be appreciated in the one-sentence translation task reported in table 1, where a hypothetical user saves over 60% of the keystrokes needed to produce a translation in a word completion scenario, and about 75% in a "unit" completion scenario 2.2 System Viewpoint The core of TRANSTYPE is a completion engine which comprises two main parts: an evaluator which assigns probabilistic scores to completion 47 This bill is very similar to its companion bill which we dealt with yesterday in the house of commons word-completion task.
A00-1019
Our approach to modeling this distribution is based to a large extent on that of the IBM group (Brown et al., 1993), but it diflhrs in one significant aspect: whereas the IBM model involves a "noisy channel" decomposition, we use a linear combination of separate predictions from a language model p(t\[t') and a translation model p(t\[s).
J93-2003
This formula follows the convention of (Brown et al., 1993) in letting so designate the null state.
J93-2003
Most later work on IMT, eg (Blanchon, 1991; Brown and Nirenburg, 1990; Maruyama and Watanabe, 1990; Whitelock et al., 1986), has followed in this vein, concentrating on improving the question/answer process by having less questions, more friendly ones, etc.
C86-1077 C90-2045 C90-3008
Both models are based on IBM translation model 2 (Brown et al., 1993) which has the 49 property that it generates tokens independently.
J93-2003
It would also be possible to check that some translations given by the user are correct with respect with some normative usage of words or terminological coherence; these facilities are already part of TRANSCHECK, another computer aided translation tool prototype developed in our laboratory (Jutras, 2000).
A00-1018
Our linear combination model is fully described in (Langlais and Foster, 2000) but can be seen as follows: 48 p(tlt',s ) = p(tlt' ) A(O(t',s)), (1) language + p(tls)\[1-~(O(t',s))! translation where .~(O(t',s)) e \[0,1\] are contextdependent interpolation coefficients.
A00-1019
