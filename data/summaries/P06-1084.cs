Elworthy (1994), in contrast, reports an accuracy of 75.49%, 80.87% and 79.12% for unsupervised word-based HMM trained on parts of the LOB corpora, with a tagset of 134 tags.
A94-1009
An unsupervised HMM model for dialectal Arabic (which is harder to be tagged than written Arabic), with accurracy of 69.83%, was presented by Duh and Kirchhoff (2005).
W05-0708
Merialdo (1994) reports an accuracy of 86.6% for an unsupervised word-based HMM, trained on a corpus of 42,186 sentences (about 1M words), over a tag set of 159 different tags.
J94-2001
Furthermore, as mentioned above, even the use of a sophisticated context-free tagger, based on (Levinger et al., 1995), gives low accuracy of 78.2%.
J95-3004
Context Free approximation [CF]: We applied the CF algorithm of Levinger et al.(1995) to estimate the likelihood of each analysis.
J95-3004
As reported by Habash and Rambow, the first work on Arabic tagging which used a corpus for training and evaluation was the work of Diab et al.(2004). Habash and Rambow were the first to use a morphological analyzer as part of their tagger.
N04-4038
Analysis If we consider the tagger which selects the most probable morphological analysis for each 669 clm 7 m 3 n‘im 16 clm 10 cl 9 hn‘im 14 hn‘im 15 h 2 n‘im 16 h 2 EOS 17 clm 8 hn‘im 11 hn‘im 12 m 4 hn‘im 14 hn‘im 15 h 2 hn‘im 11 hn‘im 12 EOS 17 hn‘im 14 hn‘im 15 hn‘im 11 hn‘im 12 EOS 17 n‘im 16 EOS 17 bcl 6 b 1 bclm 5 b 0 Figure 2: Representation of the sentence bclm hn‘im Expectation α(1,l) = piol 1.state bol 1.state,o l 1.sym (1) α(t,l) = bolt.state,olt.sym summationdisplay lprime∈olt.prev α(t− 1,lprime)aolprime t−1.state,o lt.state β( ¯T,l) = 1 (2) β(t,l) = summationdisplay lprime∈olt.next aol t.state,ol prime t+1.state bolprime t+1.state,o lprime t+1.sym β(t+ 1,lprime) Maximization ¯pii = summationtext l:ol1.state=i α(1,l)β(1,l)summationtext lα(1,l)β(1,l) (3) ¯ai,j = summationtext¯T t=2 summationtext l:olt.state=j summationtext lprime∈olt.prev:olprimet−1.state=i α(t− 1,l prime)ai,jbj,ol t.symβ(t,l)summationtext ¯T−1 t=1 summationtext l:olt.state=i α(t,l)β(t,l) (4) ¯bi,k = summationtext¯T t=1 summationtext l:olt.sym=k,olt.state=i α(t,l)β(t,l)summationtext ¯T t=1 summationtext l:olt.state=i α(t,l)β(t,l) (5) Figure 3: The learning algorithm for first-order model Initialization δ(1,l) = piol 1.state bol 1.state,o l 1.sym (6) Induction δ(t,l) = max lprime∈olt.prev δ(t− 1,lprime)aolprime t−1.state,o lt.statebolt.state,olt.sym (7) ψ(t,l) = argmax lprime∈olt.prev δ(t− 1,lprime)aolprime t−1.state,o lt.statebolt.state,olt.sym (8) Termination and path readout ¯X¯T = argmax 1≤l≤| ¯T| δ( ¯T,l) (9) ¯Xt = ψ(t+ 1, ¯Xt+1) P( ¯X) = max 1≤l≤|O ¯T | δ( ¯T,l) (10) Figure 4: The searching algorithm for first-order model 670 Order Uniform CF W 1 82.01 84.08 W 280.44 85.75 W 2 79.88 85.78 M 1 81.08 84.54 M 281.53 88.5 M 2 83.39 85.83 Table 3: Morphological Disambiguation word in the text, according to Levinger et al.(1995) approximations, with accuracy of 78.2%, as the baseline tagger, four steps of error reduction can be identified.
J95-3004
It could also mean that the tag set used for the Arabic corpora has not been adapted to the specific nature of Arabic morphology (a comment also made in (Habash and Rambow, 2005)).
P05-1071
Bar-Haim et al.(2005) developed a word segmenter and PoS tagger for Hebrew.
W05-0706
While this observation confirms Elworthy (1994), the impact of error reduction is much less than reported there for English about 70% (79 – 94).
A94-1009
In contrast to English tag sets whose sizes range from 48 to 195, the number of tags for Hebrew, based on all combinations of the morphological attributes (part-of-speech, gender, number, person, tense, status, and the affixes’ properties2), 1The Knowledge Center for Hebrew processing is developing such corpora: http://mila.cs.technion.ac.il/ 2The list of morphological attributes is described in (Yona and Wintner, 2005).
W05-0702
Levinger et al.(1995) developed a context-free method in order to acquire the morpho-lexical probabilities, from an untagged corpus.
J95-3004
Segal (2000) built a transformation-based tagger in the spirit of Brill (1995).
J95-4004
Recent analyzers provide good performance and documentation of this process (Yona and Wintner, 2005; Segal, 2000).
W05-0702
In this work, we used the backoff smoothing method, suggested by Thede and Harper (1999), with an extension of additive smoothing (Chen, 1996, 2.2.1) for the lexical probabilities (B and B2 matrices).
P99-1023
Theoretically, there might be 330,000 possible morphological tags, but in practice, Habash and Rambow (2005) extracted 2,200 different tags from their corpus, with an average number of 2 possible tags per word.
P05-1071
