Tab. 1 reports the happens-before lexico-syntactic patterns (Phb) as proposed in (Chklovski and Pantel, 2004).
W04-3205
As in our work, also in (Chklovski and Pantel, 2004), a mutualinformation-related measure is used as statistical indicator.
W04-3205
This idea has been firstly used in (Robison, 1970) and it has been explored for extracting semantic relations between nouns in (Hearst, 1992), where lexico-syntactic patterns are induced by corpora.
C92-2082
Given a verb pair (vt,vh) the assertion is for851 Lexico-syntactic patterns nominalization Pnom(vt,vh) = {“agent(vh)|num:sing vt|person:third,t:pres”, “agent(vh)|num:plur vt|person:nothird,t:pres”, “agent(vh)|num:sing vt|t:past”, “agent(vh)|num:plur vt|t:past”} happens-before (Chklovski and Pantel, 2004) Phb(vt,vh) = {“vh|t:inf and then vt|t:pres”, “vh|t:inf * and then vt|t:pres”, “vh|t:past and then vt|t:pres”, “vh|t:past * and then vt|t:pres”, “vh|t:inf and later vt|t:pres”, “vh|t:past and later vt|t:pres”, “vh|t:inf and subsequently vt|t:pres”, “vh|t:past and subsequently vt|t:pres”, “vh|t:inf and eventually vt|t:pres”, “vh|t:past and eventually vt|t:pres”} probabilistic entailment (Glickman et al., 2005) Ppe(vt,vh) = {“vh|person:third,t:pres” ∧ “vt|person:third,t:pres”, “vh|t:past” ∧ “vt|t:past”, “vh|t:pres cont” ∧ “vt|t:pres cont”, “vh|person:nothird,t:pres” ∧ “vt|person:nothird,t:pres”} additional sets Fagent(v) = {“agent(v)|num:sing”,“agent(v)|num:plur”} F(v) = {“v|person:third,t:present”, “v|person:nothird,t:present”,“v|t:past”} Fall(v) = {“v|person:third,t:pres”,“v|t:pres cont, “v|person:nothird,t:present”,“v|t:past”} Table 1: Nominalization and related textual entailment lexico-syntactic patterns malized in a set of textual entailment lexicosyntactic patterns, that we call nominalized patterns Pnom(vt,vh).
W04-3205
Even if, as discussed in (Chklovski and Pantel, 2004), these patterns are not specifically defined as entailment detectors, they can be useful for this purpose.
W04-3205
We focus on two methods proposed in (Chklovski and Pantel, 2004) and (Glickman et al., 2005).
W04-3205
More recently this method has been applied for structuring terminology in isa hierarchies (Morin, 1999) and for learning question-answering patterns (Ravichandran and Hovy, 2002).
P02-1006
In contrast to what is done in (Chklovski and Pantel, 2004) we decided to directly count patterns derived from different verbal forms and not to use an estimation factor.
W04-3205
Specifically, the measure Snom(vt,vh) is derived from point-wise mutual information (Church and Hanks, 1989): Snom(vt,vh) = log p(vt,vh|nom)p(v t)p(vh|pers) (3) where nom is the event of having a nominalized textual entailment pattern and pers is the event of having an agentive nominalization of verbs.
P89-1010
The measure Snom(vt,vh) indicates the relatedness between two elements composing a pair, in line with (Chklovski and Pantel, 2004; Glickman et al., 2005) (see Sec.
W04-3205
One set of lexical patterns in (Chklovski and Pantel, 2004) seems to capture the same idea: the happens-before (hb) patterns.
W04-3205
The findings described in (Keller and Lapata, 2003) suggest that the count estimations we need in our study over Subject-Verb bigrams are highly correlated to corpus counts.
J03-3005
As implicitly experimented in (Chklovski and Pantel, 2004), some beneficial effect can be obtained combining these “non-distributional” methods with the methods based on the Distributional Hypothesis.
W04-3205
The lexico-syntactic patterns introduced in (Chklovski and Pantel, 2004) have been developed to detect six kinds of verb relations: similarity, strength, antonymy, enablement, and happensbefore.
W04-3205
Hearst. 1992.
C92-2082
