As a dependence on all English words wouht result ill a huge mmflmr of aligmnent 1)arameters we use as (Brown et el., 1993) equivalence classes G over tlle English and the French words.
J93-2003
To find a Viterbi aligninent for the HMM-based model we resort to dynamic progralnming (Vogel et al., 1996).
C96-2141
3 and Model 4 Model: The fertility models of (Brown et el., 1993) explicitly model the probability l,(¢lc) that the English word c~ is aligned to 4,, = E J \]~rench words.
J93-2003
Smoothing For a t)etter estimation of infrequent events we introduce the following smoothing of alignment t)robabilities: 1 F(ajI~j-,,~) = ~" ~+ (1 -,,).p(ajlaj_l,I) in our exlleriments we use (t = 0.4. 3 Model 1 and Model 2 l~cl)lacing the (l(~,t)endence on aj-l in the HMM alignment mo(M I)y a del)endence on j, we olltain a model wlfich (:an lie seen as a zero-order Hid(l(mMarkov Model which is similar to Model 2 1)rot)ose(t t/y (Brown et al., 1993).
J93-2003
Assuming that the dominating factor in the alignment model of Model 2 is the distance relative to the diagonal line of the (j, i) plane the too(tel p(ilj, I) can 1)e structured as tbllows (Vogel et al., 1996):,'(i -, (3) v(ilj, 5 = Ei,=t r('i' l This model will be referred to as diagonal-oriented Model 2.
C96-2141
1087 Model 3 of (Brown et al., 1993) is a zero-order alignment model like Model 2 including in addition fertility paranmters.
J93-2003
In this paper we will describe extensions to tile Hidden-Markov alignment model froln (Vogel et al., 1.996) and compare tlmse to Models 1 4 of (Brown et al., 1993).
J93-2003
Therefore, the Viterbi alignment is comlmted only approximately using the method described in (Brown et al., 1993).
J93-2003
As in tile HMM we easily can extend the dependencies in the alignment model of Model 4 easily using the word class of the previous English word E = G(ci,), or the word class of the French word F = G(Ij) (Brown et al., 1993).
J93-2003
Alignment Template System The statistical machine-translation method described in (Och et al., 1999) is based on a word aligned traiifing corIms and thereby makes use of singleword based alignment models.
W99-0604
For more information about the alignment template approach see (Och et at., 1999).
W99-0604
Model 4 of (Brown et al., 1993) is also a first-order alignment model (along the source positions) like the HMM, trot includes also fertilities.
J93-2003
Most SMT models (Brown et al., 1993; Vogel et al., 1996) try to model word-to-word corresl)ondences between source and target words using an alignment nmpl)ing from source l)osition j to target position i = aj.
C96-2141 J93-2003
In the E-step the lexical and alignment 1086 counts for one sentenee-i)air (f, e) are calculated: c(flc; f, e) = E P"(alf' e) ~ 5(f, f~)5(e, c~) a i,j,.:(ill', z; f, e) = E/','(air, e) aj) a j In the M-step the lexicon and translation probabilities are: p(fle) o< ~-~c(fle;f('~),e (~)) 8 P(ili',I) o(Ec(ili',I;fO),e(~)) 8 To avoid the smlunation ov(;r all possible aligmnents a, (Vogel et el., 1996) use the maximum apllroximation where only the Viterbi alignlnent t)ath is used to collect counts.
C96-2141
Tile full description of Model 4 (Brown et al., 1993) is rather complica.ted as there have to be considered tile cases that English words have fertility larger than one and that English words have fertility zero.
J93-2003
