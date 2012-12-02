Most work in the area of unknown words and tagging deals with predicting part-of-speech information based on word endings and affixation information, as shown by work in (Mikheev, 1996), (Mikheev, 1997), (Weischedel et al., 1993), and (Thede, 1998).
J93-2006 J97-3003 P96-1043 P98-2251
The tagger was tested on two corpora-the Brown corpus (from the Treebank II CDROM (Marcus et al., 1993)) and the Wall Street Journal corpus (from the same source).
J93-2004
A better smoothing approach for lexical information could possibly be created by using some sort of word class idea, such as the genotype idea used in (Tzoukermann and Radev, 1996), to improve our /5 estimate.
W96-0101
There are many possible answers, some of which are considered by (Thede, 1998): use the longest matching suffix, use an entropy measure to determine the "best" affix to use, or use an average.
P98-2251
Much research has been done to improve tagging accuracy using several different models and methods, including: hidden Markov models (HMMs) (Kupiec, 1992), (Charniak et al., 1993); rule-based systems (Brill, 1994), (Brill, 1995); memory-based systems (Daelemans et al., 1996); maximum-entropy systems (Ratnaparkhi, 1996); path voting constraint systems (Tiir and Oflazer, 1998); linear separator systems (Roth and Zelenko, 1998); and majority voting systems (van Halteren et al., 1998).
J95-4004 P98-1081 P98-2186 W96-0102 W96-0213
The Penn Treebank documentation (Marcus et al., 1993) defines a commonly used set of tags.
J93-2004
The standard trigram tagger data is from (Weischedel et al., 1993).
J93-2006
The MBT (Daelemans et al., 1996) 180 Tagger Type Standard Trigram (Weischedel et al., 1993) MBT (Daelemans et al., 1996) Rule-based (Brill, 1994) Maximum-Entropy (Ratnaparkhi, 1996) Full Second-Order HMM SNOW (Roth and Zelenko, 1998) Voting Constraints (Tiir and Oflazer, 1998) Full Second-Order HMM Known Unknown Overall Open/Closed Lexicon? 96.7% 85.0% 96.3% open 96.7% 90.6% 2 96.4% open 82.2% 96.6% open 97.1% 97.2% 85.6% 84.9% 97.5% 96.6% 96.9% 98.05% open open closed closed closed Testing Method full WSJ 1 fixed WSJ cross-validation fixed full WSJ 3 fixed full WSJ 3 full WSJ cross-validation fixed subset of WSJ 4 subset of WSJ cross-validation 5 full WSJ cross-validation Table 2: Comparison between Full Second-Order HMM and Other Taggers did not include numbers in the lexicon, which accounts for the inflated accuracy on unknown words.
J93-2006 P98-2186 W96-0102 W96-0213
Thede. 1998.
P98-2251
This model makes use of second-order approximations for a hidden Markov model and 8Mikheev (1997) also separates suffix probabilities into different estimates, but fails to provide any data illustrating the implied accuracy increase.
J97-3003
