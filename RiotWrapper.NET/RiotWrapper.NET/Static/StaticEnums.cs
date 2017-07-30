namespace RiotWrapper.Static
{
    public enum Region : byte
    {
        BR1,
        EUN1,
        EUW1,
        JP1,
        KR,
        LA1,
        LA2,
        NA1,
        OC1,
        TR1,
        RU,
        PBE1
    }

    public enum ChampionDataStyle : byte
    {
        all,
        allytips,
        blurb,
        enemytips,
        image,
        info,
        lore,
        partype,
        passive,
        recommended,
        skins,
        spells,
        stats,
        tags
    }

    public enum ItemDataStyle : byte
    {
        all,
        colloq,
        consumeOnFull,
        consumed,
        depth,
        from,
        gold,
        groups,
        hideFromAll,
        image,
        inStore,
        into,
        maps,
        requiredChampion,
        sanitizedDescription,
        specialRecipe,
        stacks,
        stats,
        tags,
        tree
    }

    public enum RuneDataStyle
    {
        all,
        image,
        sanitizedDescription,
        stats,
        tags
    }

    public enum MasteryDataStyle
    {
        all,
        image,
        masteryTree,
        prereq,
        ranks,
        sanitizedDescription,
        tree
    }

    public enum SummonerSpellDataStyle
    {
        all,
        cooldown,
        cooldownBurn,
        cost,
        costBurn,
        costType,
        effect,
        effectBurn,
        image,
        key,
        leveltip,
        maxrank,
        modes,
        range,
        rangeBurn,
        resource,
        sanitizedDescription,
        sanitizedTooltip,
        tooltip,
        vars
    }
}
