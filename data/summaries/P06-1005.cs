We test on the ANC Test set (1291 instances) also used in Bergsma (2005) (highest resolution accuracy reported: 73.3%), the anaphoralabelled portion of AQUAINT used in Cherry and Bergsma (2005) (1078 instances, highest accuracy: 71.4%), and the anaphoric pronoun subset of the MUC7 (1997) coreference evaluation formal test set (169 instances, highest precision of 62.1 reported on all pronouns in (Ng and Cardie, 2002)).
P02-1014 W05-0612
Since no such corpus exists, researchers have used coarser features learned from smaller sets through supervised learning (Soon et al., 2001; Ng and Cardie, 2002), manually-de ned coreference patterns to mine speci c kinds of data (Bean and Riloff, 2004; Bergsma, 2005), or accepted the noise inherent in unsupervised schemes (Ge et al., 1998; Cherry and Bergsma, 2005).
J01-4004 N04-1038 P02-1014 W05-0612 W98-1119
Constraints and preferences have also been applied together as decision nodes on a decision tree (Aone and Bennett, 1995).
P95-1017
Indeed, coreference resolution research has focused on the importance of the strategy for combining well known constraints and preferences (Mitkov, 1997; Ng and Cardie, 2002), devoting little attention to the development of new features for these dif cult cases.
P02-1014 W97-1303
(Ge et al., 1998; Cherry and Bergsma, 2005)).
W05-0612 W98-1119
Compatibility Researchers since Dagan and Itai (1990) have variously argued for and against the utility of collocation statistics between nouns and parents for improving the performance of pronoun resolution.
C90-3063
The application of world knowledge to pronoun resolution has been limited to the semantic compatibility between a candidate noun and the pronoun’s context (Yang et al., 2005).
P05-1021
We encode the semantic compatibility between a noun and its parse tree parent (and grammatical relationship with the parent) using mutual information (MI) (Church and Hanks, 1989).
P89-1010
Kehler et al.(2004) saw no apparent gain from using semantic compatibility information, while Yang et al.(2005) saw about a 3% improvement with compatibility data acquired by searching on the world wide web.
N04-1037 P05-1021
Bean and Riloff (2004) used bootstrapping to extend their semantic compatibility model, which they called contextual-role knowledge, by identifying certain cases of easily-resolved anaphors and antecedents.
N04-1038
Clearly, promoting competitive evaluation of pronoun resolution scoring systems by giving competitors equivalent real-world preprocessing output along the lines of (Barbu and Mitkov, 2001) remains the best way to isolate areas for system improvement.
P01-1006
Constraints can be applied as a preprocessing step to scoring candidates based on distance, grammatical role, etc., with scores developed either manually (Lappin and Leass, 1994), or through a machine-learning algorithm (Kehler et al., 2004).
J94-4002 N04-1037
Ideally we would assess the bene t of our probabilistic features using the same state-of-the-art preprocessing modules employed by others such as (Yang et al., 2005) (who additionally use a search engine for compatibility scoring).
P05-1021
