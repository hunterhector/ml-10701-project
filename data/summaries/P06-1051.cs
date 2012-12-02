As described in (Collins and Duffy, 2002), ∆ can be computed in O(|Nt1| × |Nt2|).
P02-1034
A first class of methods defines measures of the distance or similarity between T and H either assuming the independence between words (Corley and Mihalcea, 2005; Glickman et al., 2005) in a bag-of-word fashion or exploiting syntactic interpretations (Kouylekov and Magnini, 2005).
W05-1203
We also used the following resources: The Charniak parser (Charniak, 2000) and the morphalemmatiser (Minnen et al., 2001) to carry out the syntactic and morphological analysis.
A00-2018
The wn::similarity package (Pedersen et al., 2004) to compute the Jiang&Conrath (J&C) distance (Jiang and Conrath, 1997) as in (Corley and Mihalcea, 2005).
N04-3012 W05-1203
Third, the dramatic improvement observed in (Corley and Mihalcea, 2005) on the dataset “Train:D1-Test:T1” is given by the idf rather than the use of the J&C similarity (second vs.
W05-1203
In line with (Corley and Mihalcea, 2005), we define it as: s1(T,H) = summationdisplay (wt,wh)∈A simw(wt,wh)×idf(wh) summationdisplay wh∈WH idf(wh) (3) where idf(w) is the inverse document frequency of the word w.
W05-1203
SVM-light-TK3 (Moschitti, 2006) which encodes the basic tree kernel function, KT, in SVMlight (Joachims, 1999).
E06-1015
For example, the sentence T1: “At the end of the year, all solid companies pay dividends.” entails the hypothesis H1: “At the end of the year, all solid insurance companies pay dividends.” but it does not entail the hypothesis H2: “At the end of the year, all solid companies pay cash dividends.” Although these implications are uncontroversial, their automatic recognition is complex if we rely on models based on lexical distance (or similarity) between hypothesis and text, e.g., (Corley and Mihalcea, 2005).
W05-1203
1. As the corresponding maximum quantifies the alignment degree, we could define a cross-pair similarity as follows: Ks((Tprime,Hprime),(Tprimeprime,Hprimeprime)) = max c∈C parenleftBig KT(t(Hprime,c),t(Hprimeprime,i)) +KT(t(Tprime,c),t(Tprimeprime,i) parenrightBig, (6) where as KT(t1,t2) we use the tree kernel function defined in (Collins and Duffy, 2002).
P02-1034
This rule is also described in (Hearst, 1992).
C92-2082
These transformations are logical rules in (Bos and Markert, 2005) or sequences of allowed rewrite rules in (de Salvo Braz et al., 2005).
H05-1079
Our approach is in line with many other researches (e.g., (Corley and Mihalcea, 2005; Glickman et al., 2005)).
W05-1203
However, previous work (e.g., (Zaenen et al., 2005)) suggests that determining whether or not a text T entails a hypothesis H is quite complex even when all the needed information is explicitly asserted.
W05-1206
Second, we can use one of the WordNet (Miller, 1995) similarities indicated with d(lw,lwprime) (in line with what was done in (Corley and Mihalcea, 2005)) and different relation between words such as the lexical entailment between verbs (Ent) and derivationally relation between words (Der).
W05-1203
Indeed, if we encode such movements in the syntactic parse trees of texts and hypotheses, we can use interesting similarity measures defined for syntactic parsing, e.g., the tree kernel devised in (Collins and Duffy, 2002).
P02-1034
Hearst. 1992.
C92-2082
